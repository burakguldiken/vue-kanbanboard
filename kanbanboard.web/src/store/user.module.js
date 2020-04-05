import ApiService from "@/common/api.service";
import JwtService from "@/common/jwt.service";
import MenuService from '@/common/menu.service';
import UserService from '@/common/user.service';
import {
    LOGIN,
    LOGOUT,
    CHECK_USER,
    LIST_USER,
} from "./actions.type";
import {
    SET_USER,
    PURGE_USER, 
    GET_USERS,
} from "./mutations.type";

const state = {
    user: JSON.parse(UserService.getUser()),
    isAuthenticated: !!JwtService.getToken(),
    menu: JSON.parse(MenuService.getMenu()),
    userList: [],
}

const getters = {
    currentUser: state => {
        return state.user;
    },
    isAuthenticated: state => {
        return state.isAuthenticated;
    },
    getMainMenu: state => {
        return state.menu.filter(x => x.parentMenuId === 0 && x.isShow === 2);
    },
    getParentMenu: state => id => {
        return state.menu.filter(x => x.parentMenuId === id && x.isShow === 2);
    },
    isParentMenu: state => id => {
        return state.menu.filter(x => x.parentMenuId === id).length > 0 ? true : false
    },
    userList: state => {
        return state.userList;
    },
}

const actions = {
    [LOGIN](context, user) {
        return new Promise((resolve, reject) => {
            ApiService.post("user/login", user).then((data) => {
                context.commit(SET_USER, data.data);
                resolve(data);
            }).catch((err) => {
                reject(err)
            })
        });
    },
    [LOGOUT](context) {
        context.commit(PURGE_USER);
    },
    [CHECK_USER](context) {
        if (JwtService.getToken()) {
            ApiService.setHeader();
            return true;
        } else {
            context.commit(PURGE_USER);
        }
    },
    [LIST_USER](context) {
        return new Promise((resolve, reject) => {
            ApiService.post("user/getusers").then((data) => {
                context.commit(GET_USERS, data.data);
                resolve(data)
            }).catch((err) => {
                reject(err)
            })
        });
    },
}

const mutations = {
    [SET_USER](state, user) {
        state.isAuthenticated = true;
        JwtService.saveToken(user.token);
        state.user = user.user;
        state.menu = user.menus;
        MenuService.saveMenu(JSON.stringify(user.menus));
        UserService.saveUser(JSON.stringify(user.user));
    },
    [PURGE_USER](state) {
        state.isAuthenticated = false;
        state.user = {};
        state.menu = []
        JwtService.destroyToken();
        MenuService.destroyMenu();
        ApiService.purgeHeader();
    },
    [GET_USERS](state, data) {
        state.userList = data.userList;
    },
}

export default {
    state,
    actions,
    mutations,
    getters
}