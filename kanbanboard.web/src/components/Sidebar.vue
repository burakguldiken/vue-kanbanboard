<template>
  <v-navigation-drawer color="#ff4f00" dark app fixed inset v-model="toggle" @transitionend="drawerStatus" height="100%">
    <v-app-bar color="#363636" dark>
      <v-col cols="12" class="align-center">
        <v-img width="80%" src="../assets/jira.png"></v-img>
      </v-col>
    </v-app-bar>
    <v-list>
      <div v-for="(item,index) in GetMainMenu()" :key="index">
        <v-list-item v-if="!isParentMenu(item.id)" class="listItem" @click="route(item.route)">
          <v-list-item-icon>
            <v-icon>{{item.icon}}</v-icon>
          </v-list-item-icon>

          <v-list-item-title>{{item.name}}</v-list-item-title>
        </v-list-item>

        <v-list-group v-else :prepend-icon="item.icon" :value="value" no-action>
          <template v-slot:activator>
            <v-list-item-title>{{item.name}}</v-list-item-title>
          </template>

          <v-list-item
            v-for="(subItem,subIndex) in GetSubMenu(item.id)"
            :key="subIndex"
            @click="route(subItem.route)"
            link
          >
            <v-list-item-title v-text="subItem.name"></v-list-item-title>          
          </v-list-item>
        </v-list-group>
      </div>
    </v-list>
  </v-navigation-drawer>
</template>

<script>
export default {
  props: {
    toggle: {
      type: Boolean,
      required: false,
      default: false
    }
  },
  data: () => ({
    value: false
  }),
  methods: {
    drawerStatus() {
      var openDrawer = this.toggle;
      if (!openDrawer) {
        this.$emit("closeDrawer", openDrawer);
      }
    },
    GetMainMenu() {
      window.console.log(this.$store.getters.getMainMenu);
      return this.$store.getters.getMainMenu;
    },
    GetSubMenu(id) {
      return this.$store.getters.getParentMenu(id);
    },
    isParentMenu(id) {
      return this.$store.getters.isParentMenu(id);
    },
    route(pathUrl) {
      if (pathUrl !== "" || pathUrl !== undefined) {
        this.$router.push({ path: pathUrl });
      }
    }
  }
};
</script>

<style scoped>
.listItem {
  cursor: pointer;
}
</style>