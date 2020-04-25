<template>
<v-container>
  <div class="name-card">
    <v-card class="socialCard" :color="color" ref="card" :dark="dark" :img="cardBgImage">
      <v-responsive v-if="showTopNav">
        <v-layout row justify-space-between class="ma-0">
          <v-flex xs2>
            <v-icon class="ml-3 mt-3">far fa-times-circle</v-icon>
          </v-flex>
          <v-flex xs2 class="text-sm-right">
            <v-icon class="mr-3 mt-3">fas fa-ellipsis-v</v-icon>
          </v-flex>
        </v-layout>
      </v-responsive>
      <v-card-text>
        <div clas class="layout ma-0 align-center" :class="cardLayout">
          <v-avatar :size="avatarSize">
            <img v-bind:src="avatar.src" v-bind:alt="name" v-if="showAvatar">
            <span v-else class="white--text headline">{{ name.charAt(0) }}</span>
          </v-avatar>
          <div class="flex" :class="textAlign">
            <div class="subheading white--text">{{name}}</div>
            <span class="caption white--text">{{jobTitle}}</span>
          </div>
        </div>
      </v-card-text>
    </v-card>
  </div>
</v-container>
</template>

<script>
export default {
  props: {
    name: {
      type: String,
      default: ''
    },
    avatar: {
      type: Object,
      default: null
    },
    jobTitle: {
      type: String,
      default: ''
    },
    cardBgImage: {
      type: String,
    },
    color: {
      type: String,
      default: ''
    },
    dark: {
      type: Boolean,
      default: false
    },
    bottomNav: {
      type: Boolean,
      default: false
    },
    topNav: {
      type: Boolean,
      default: false
    },
    mini: {
      type: Boolean,
      default: false
    }
  },
  data() {
    return {
    }
  },
  computed: {
    cardLayout () {
      const vm = this;
      return vm.mini ? 'row' : 'column';
    },
    textAlign () {
      const vm = this;
      return vm.mini ? 'text-sm-right' : 'text-sm-center';
    },
    avatarSize () {
      const vm = this;
      return vm.mini ? '54' : '96';
    },
    showAvatar () {
      const vm = this;
      return vm.avatar && vm.avatar.src;
    },
    showBottomNav () {
      const vm = this;
      return !vm.mini && vm.bottomNav;
    },
    showTopNav () {
      const vm = this;
      return !vm.mini && vm.topNav;
    }
  }
}
</script>
