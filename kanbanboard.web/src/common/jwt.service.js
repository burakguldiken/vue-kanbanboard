const PORTAL_ID_TOKEN_KEY = 'portal_id_token';
const API_TOKENS = 'api_tokens';

export const getToken = () => {
    return window.localStorage.getItem(PORTAL_ID_TOKEN_KEY);
};

export const saveToken = token => {
    window.localStorage.setItem(PORTAL_ID_TOKEN_KEY,token);
};

export const destroyToken = () => {
    window.localStorage.removeItem(PORTAL_ID_TOKEN_KEY)
};

export const getApiTokens = () => {
    return window.localStorage.getItem(API_TOKENS);
}

export const saveApiTokens = tokens => {
    window.localStorage.setItem(API_TOKENS,tokens);
}

export const destroyApiTokens = () => {
    window.localStorage.removeItem(API_TOKENS)
}

export default{
    getToken,
    saveToken,
    destroyToken,
    getApiTokens,
    saveApiTokens,
    destroyApiTokens
}