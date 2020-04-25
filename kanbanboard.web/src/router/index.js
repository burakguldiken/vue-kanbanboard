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
      name: "Ayarlar",
      path: "/Ayarlar",
      component: () => import("@/views/settings/View_UserProfile"),
    },
    {
      name:"Bildirimler",
      path: "/Bildirimler",
      component: () => import("@/views/notification/view_notifications")
    },
    {
      name:"Gecmis",
      path: "/Gecmis",
      component: () => import("@/views/history/view_history")
    },
    {
      name:"Takım",
      path: "/Takım",
      component: () => import("@/views/team/view_team")
    },
    {
      name: '/*',
      path: '/*',
      component: () => import('@/views/errors/404')
    },
  ]
});