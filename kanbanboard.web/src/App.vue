<template>
 <v-app>
    <toolbar
      v-if="$store.getters.isAuthenticated"
      @toggleNavigationBar="drawer = !drawer"
      v-on:logout="logout"
    />
    <sidebar v-if="$store.getters.isAuthenticated" :toggle="drawer" v-on:closeDrawer="closeDrawer" />
    <v-content>
      <router-view></router-view>
    </v-content> 
    <v-overlay :value="$store.getters.getLoadingState">
      <vue-loaders-pacman scale="1"></vue-loaders-pacman>
    </v-overlay>
    <pagefooter v-if="$store.getters.isAuthenticated" class="hidden-sm-and-down" />
  </v-app>
</template>

<script>
import { LOGOUT } from "@/store/actions.type";
export default {
  name: "app",
  data: () => ({
    drawer: true
  }),
  methods: {
    closeDrawer(obj) {
      if (obj !== this.drawer) {
        this.drawer = obj;
      }
    },
    logout() {
      this.$store.dispatch(LOGOUT).then(() => {
        this.$router.push({ path: "/" });
      });
    }
  }
};
</script>