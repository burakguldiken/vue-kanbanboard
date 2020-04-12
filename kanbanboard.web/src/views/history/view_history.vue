<template>
  <v-container>
    <v-row justify="center">
      <v-col cols="12" sm="12" md="12">
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
                  <v-icon small color="red">fa fa-star</v-icon>
                </v-list-item-action>
              </v-list-item>
            </template>
          </v-list>
        </v-card>
      </v-col>
      <v-col cols="4"></v-col>
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
        },
        {
          header: "Last Week"
        },
        { divider: true },
        {
          avatar: "https://picsum.photos/250/300?image=1008",
          title: "Breakfast?",
          subtitle:
            "<span class='font-weight-bold'>LaToya</span> &mdash; Do you want to hang out?"
        },
        {
          avatar: "https://picsum.photos/250/300?image=839",
          title:
            'Winter Porridge <span class="grey--text text--lighten-1"></span>',
          subtitle:
            "<span class='font-weight-bold'>cc: Daniel</span> &mdash; Tell me more..."
        },
        {
          avatar: "https://picsum.photos/250/300?image=145",
          title: "Oui oui",
          subtitle:
            "<span class='font-weight-bold'>Nancy</span> &mdash; Do you see what time it is?"
        }
      ]
    };
  }
};
</script>

<style scoped>
.listItem:hover {
  background-color: rgb(108, 153, 236);
}
</style>