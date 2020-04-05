const PORTAL_MENU_KEY = 'portal_user_menu';

export const getMenu =  () => {
    return window.localStorage.getItem(PORTAL_MENU_KEY)
}

export const saveMenu = menu => {
    window.localStorage.setItem(PORTAL_MENU_KEY,menu);
}

export const destroyMenu = () => {
    window.localStorage.removeItem(PORTAL_MENU_KEY)
}

export default {getMenu,saveMenu,destroyMenu};