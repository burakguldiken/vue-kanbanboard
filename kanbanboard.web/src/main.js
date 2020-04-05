import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify';
import store from './store';
import { CHECK_USER } from "./store/actions.type";
import ApiService from "./common/api.service";
import { setupComponents } from "./store/setup.components";
import VueDraggable from "vue-draggable";
import  './plugins/chartist';
// import VueFeatherIcon from "vue-feather-icon";

Vue.config.productionTip = false

ApiService.init();
setupComponents(Vue);

Vue.use(VueDraggable);
// Vue.use(VueFeatherIcon);

router.beforeEach((to, from, next) => {  
  store.dispatch(CHECK_USER).then();
  const isAuthenticated = store.getters.isAuthenticated;
  if(isAuthenticated){
    if(to.path === '/'){
      router.push({path:'/Anasayfa'})
    }
  }
  if(!isAuthenticated){
    if(to.path !=='/'){
      router.push({path:'/'})
    }
  }
  next();
});

new Vue({
  router,
  vuetify,
  store,
  render: h => h(App)
}).$mount('#app')