import Vue from "vue";
import Router from "vue-router";

Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [
    {
      name: "login",
      path: "/",
      component: () => import("@/views/user/Login")
    },
    {
      name: "home",
      path: "/Anasayfa",
      component: () => import("@/views/home/Index"),
    },
    {
      name: "Projeler",
      path: "/Projeler",
      component: () => import("@/views/project/view_project"),
    },
    {
      name: "Dashboard",
      path: "/Dashboard",
      component: () => import("@/views/dashboard/view_dashboard"),
    },
    {
      name: "View_UserProfile",
      path: "/Ayarlar",
      component: () => import("@/views/settings/View_UserProfile"),
    },
    {
      name: '/*',
      path: '/*',
      component: () => import('@/views/errors/404')
    },
  ]
});