import {
    IS_LOADING
} from "./actions.type";
import { SET_LOADING } from "./mutations.type";

const state = {
    isLoading : false,
}

const actions = {
    [IS_LOADING](context){
        context.commit(SET_LOADING)
    }
}

const mutations = {
    [SET_LOADING](state){
        state.isLoading = !state.isLoading;
    }
}

const getters = {
    getLoadingState(state){
        return state.isLoading;
    }
}

export default{
    state,
    actions,
    mutations,
    getters
}