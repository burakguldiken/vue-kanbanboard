<template>
  <div>
    <v-app-bar color="#363636" app dark>
      <v-app-bar-nav-icon @click="toggleNavigationBar"></v-app-bar-nav-icon>
      <v-toolbar-title>{{this.$route.params.name}}</v-toolbar-title>
      <div class="flex-grow-1"></div>   
      <v-btn icon @click="$router.push({name:'/KullaniciAyarlari'})">
        <v-icon>fa fa-user-cog</v-icon>
        </v-btn>   
      <v-btn icon @click="logout">
        <v-icon>fa-sign-out-alt</v-icon>
      </v-btn>
    </v-app-bar>
  </div>
</template>

<script>
export default {
  data: () => ({
    drawer: false
  }),
  methods: {
    toggleNavigationBar() {
      const vm = this;
      vm.$emit("toggleNavigationBar");
    },
    logout(){
      this.$emit("logout");
    }
  }
};
</script>