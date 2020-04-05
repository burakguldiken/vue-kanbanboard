const PORTAL_USER_KEY= 'portal_userItem';

export const getUser = () => {
    return window.localStorage.getItem(PORTAL_USER_KEY)
};

export const saveUser = user => {
    window.localStorage.setItem(PORTAL_USER_KEY,user)
};

export const destroyUser = () => {
    window.localStorage.removeItem(PORTAL_USER_KEY);
};

export default{getUser,saveUser,destroyUser};