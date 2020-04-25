<template>
  <v-container>
    <v-row justify="center">
      <v-col class="mt-3" cols="12" xs="12" sm="3" md="3" lg="3">
        <v-row>
          <v-select :items="select" label="Select Project" prepend-inner-icon="fas fa-project-diagram" outlined></v-select>
        </v-row>
        <v-row>
          <v-card class="mx-auto">
            <v-toolbar color="#0866C6" dark>
              <v-app-bar-nav-icon></v-app-bar-nav-icon>

              <v-toolbar-title>Users</v-toolbar-title>

              <v-spacer></v-spacer>

              <v-btn icon>
                <v-icon>fa fa-users</v-icon>
              </v-btn>
            </v-toolbar>

            <v-list three-line>
              <template v-for="(item, index) in items2">
                <v-subheader v-if="item.header" :key="item.header" v-text="item.header"></v-subheader>

                <v-divider v-else-if="item.divider" :key="index" :inset="item.inset"></v-divider>

                <v-list-item v-else :key="item.title">
                  <v-list-item-avatar>
                    <v-img :src="item.avatar"></v-img>
                  </v-list-item-avatar>

                  <v-list-item-content>
                    <v-list-item-title v-html="item.title"></v-list-item-title>
                    <v-list-item-subtitle v-html="item.subtitle"></v-list-item-subtitle>
                  </v-list-item-content>

                  <v-list-item-icon>
                    <v-icon color="green">fa fa-share</v-icon>
                  </v-list-item-icon>
                </v-list-item>
              </template>
            </v-list>
          </v-card>
        </v-row>
      </v-col>
      <v-col cols="12" xs="12" sm="8" md="8" lg="8">
        <v-row justify="center" align="center">
          <v-col cols="12">
            <v-card align="center" justify="center" cols="12">
              <v-img class="white--text image" src="@/assets/task4.png"></v-img>
            </v-card>
          </v-col>
          <v-col cols="12">
            <v-card>
              <v-toolbar style="background-color:#0866C6">
                <v-toolbar-title class="white--text ml-12">History</v-toolbar-title>
                <v-btn color="red" dark medium absolute bottom left fab>
                  <v-icon>fa fa-history</v-icon>
                </v-btn>
              </v-toolbar>
              <v-list two-line>
                <template v-for="(item, index) in items">
                  <v-subheader v-if="item.header" :key="item.header" inset>{{ item.header }}</v-subheader>

                  <v-divider v-else-if="item.divider" :key="index" inset></v-divider>

                  <v-list-item v-else :key="item.title" ripple class="listItem">
                    <v-list-item-avatar>
                      <img :src="item.avatar" />
                    </v-list-item-avatar>
                    <v-list-item-content>
                      <v-list-item-title v-html="item.title"></v-list-item-title>
                      <v-list-item-subtitle v-html="item.subtitle"></v-list-item-subtitle>
                    </v-list-item-content>
                    <v-list-item-action>
                      <v-icon small>fa fa-star</v-icon>
                    </v-list-item-action>
                  </v-list-item>
                </template>
              </v-list>
            </v-card>
          </v-col>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      checkbox: true,
      items: [
        {
          header: "Today"
        },
        { divider: true },
        {
          avatar: "https://picsum.photos/250/300?image=660",
          title: "Meeting @ Noon",
          subtitle:
            "<span class='font-weight-bold'>Spike Lee</span> &mdash; I'll be in your neighborhood"
        },
        {
          avatar: "https://picsum.photos/250/300?image=821",
          title: 'Summer BBQ <span class="grey--text text--lighten-1"></span>',
          subtitle:
            "<span class='font-weight-bold'>to Operations support</span> &mdash; Wish I could come."
        },
        {
          avatar: "https://picsum.photos/250/300?image=783",
          title: "Yes yes",
          subtitle:
            "<span class='font-weight-bold'>Bella</span> &mdash; Do you have Paris recommendations"
        },
        {
          header: "Yesterday"
        },
        { divider: true },
        {
          avatar: "https://picsum.photos/250/300?image=1006",
          title: "Dinner tonight?",
          subtitle:
            "<span class='font-weight-bold'>LaToya</span> &mdash; Do you want to hang out?"
        },
        {
          avatar: "https://picsum.photos/250/300?image=146",
          title: "So long",
          subtitle:
            "<span class='font-weight-bold'>Nancy</span> &mdash; Do you see what time it is?"
        }
      ],

      items2: [
        { header: "Kanban Project" },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/1.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        },
        { divider: true, inset: true },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/2.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        },
        { divider: true, inset: true },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/3.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        },
        { divider: true, inset: true },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/4.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        },
        { divider: true, inset: true },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/5.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/4.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        },
        { divider: true, inset: true },
        {
          avatar: "https://cdn.vuetifyjs.com/images/lists/5.jpg",
          title: "<span class='font-weight-bold'>Burak Güldiken</span>",
          subtitle: "burakguldiken1@gmail.com"
        }
      ],

      select: []
    };
  }
};
</script>

<style scoped>
.listItem:hover {
  background-color: rgb(108, 153, 236);
}

.image {
  height: 50%;
  width: 50%;
}
</style>