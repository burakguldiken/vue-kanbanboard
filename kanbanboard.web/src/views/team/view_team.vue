<template>
  <v-container>
    <v-row align="center" justify="center">
      <v-col cols="11" sm="11" xs="12" md="12" lg="12">
        <v-card align="center" justify="center" class="mx-auto" max-width="1500">
          <v-img class="image" height="350px" src="@/assets/t7.jpg"></v-img>
        </v-card>
      </v-col>
    </v-row>
    <v-row align="center" justify="center">
      <v-col cols="11">
        <v-card>
          <v-tabs
            v-model="tab"
            background-color="#0866C6"
            class="elevation-2"
            dark
            :centered="centered"
            :grow="grow"
            :vertical="vertical"
            :right="right"
            :prev-icon="prevIcon ? 'mdi-arrow-left-bold-box-outline' : undefined"
            :next-icon="nextIcon ? 'mdi-arrow-right-bold-box-outline' : undefined"
            :icons-and-text="icons"
          >
            <v-tab>
              <v-badge class="mt-1" color="red" content="3">
                <v-icon class="mr-1">fa fa-users</v-icon>
              </v-badge>
              <span class="white--text ml-3">My Teams</span>
            </v-tab>
            <v-tab>
              <v-icon class="mr-3" style="color:white">fas fa-plus-circle</v-icon>
              <span class="white--text">New Team</span>
            </v-tab>
            <v-tab>
              <v-icon class="mr-3" style="color:white">fa fa-user</v-icon>
              <span class="white--text">Add User</span>
            </v-tab>

            <v-tab-item>
              <v-row class="ma-0">
                <v-col cols="12" sm="3" xs="12" lg="3" md="3">
                  <v-card xs12 md3 lg3>
                    <v-treeview
                      v-model="tree"
                      :open="open"
                      :items="items"
                      activatable
                      item-key="name"
                      style="font-weight:bold;"
                      open-on-click
                    >
                      <template v-slot:prepend="{ item, open }">
                        <v-icon
                          style="color:#0866C6"
                          v-if="!item.file"
                        >{{ open ? 'fas fa-folder-open' : 'fas fa-folder' }}</v-icon>
                        <v-icon style="color:green" v-else>{{ files[item.file] }}</v-icon>
                      </template>
                    </v-treeview>
                  </v-card>
                </v-col>
                <v-col cols="12" sm="9" xs="12" md="9" lg="9">
                  <v-row>
                    <v-col cols="12" sm="4" xs="12" lg="4" md="4" v-for="(item,index) in users" :key="index">
                      <v-card class="mx-auto" max-width="400">
                        <v-img
                          align="center"
                          justify="center"
                          class="white--text align-end"
                          height="200px"
                          style="background-color:#a0a0a0"
                        >
                          <v-avatar color="orange" size="130">
                            <span class="white--text headline">62</span>
                          </v-avatar>

                          <v-card-title>{{item.name}}</v-card-title>
                        </v-img>

                        <v-card-subtitle class="pb-0">Full-Stack Developer</v-card-subtitle>

                        <v-card-text class="text--primary">
                          <div>05319761982</div>

                          <div>burakguldiken1@gmail.com</div>
                        </v-card-text>

                        <v-card-actions>
                          <v-btn small style="background-color:red">
                            <v-icon small style="color:white">fas fa-trash-alt</v-icon>
                          </v-btn>

                          <v-btn small style="background-color:#0866C6">
                            <v-icon small style="color:white">fas fa-user-shield</v-icon>
                          </v-btn>
                        </v-card-actions>
                      </v-card>
                    </v-col>
                  </v-row>
                </v-col>
              </v-row>
            </v-tab-item>
            <v-tab-item>
              <!--tab 2 -->
            </v-tab-item>
            <v-tab-item>
              <v-card flat>
                <v-card-text>
                  <p>Fusce a quam. Phasellus nec sem in justo pellentesque facilisis. Nam eget dui. Proin viverra, ligula sit amet ultrices semper, ligula arcu tristique sapien, a accumsan nisi mauris ac eros. In dui magna, posuere eget, vestibulum et, tempor auctor, justo.</p>

                  <p
                    class="mb-0"
                  >Cras sagittis. Phasellus nec sem in justo pellentesque facilisis. Proin sapien ipsum, porta a, auctor quis, euismod ut, mi. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nam at tortor in tellus interdum sagittis.</p>
                </v-card-text>
              </v-card>
            </v-tab-item>
          </v-tabs>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
//import socialWidget from "../home/Socialwidget";
export default {
  // components: {
  //   socialWidget
  // },
  data() {
    return {
      tab: 0,
      icons: false,
      centered: false,
      grow: true,
      vertical: false,
      prevIcon: true,
      nextIcon: true,
      right: false,
      open: ["Projects"],
      files: {
        vue: "fab fa-vuejs"
      },
      tree: [],
      items: [
        {
          name: "Projects",
          children: [
            {
              name: "Task Management System",
              file: "vue"
            },
            {
              name: "Vue Template",
              file: "vue"
            },
            {
              name: ".Net Core Api",
              file: "vue"
            },
            {
              name: "Project Test",
              file: "vue"
            }
          ]
        }
      ],
      users: [
        {
          name: "Burak Güldiken"
        },
        {
          name: "Test 1"
        },
        {
          name: "Test 2"
        },
        {
          name: "Test 3"
        }
      ]
    };
  }
};
</script>

<style scoped>
.image {
  height: 50%;
  width: 50%;
}
</style>