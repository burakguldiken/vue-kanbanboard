<template>
  <v-container fluid>
    <v-row class="ma-0">
      <v-col class="mr-12" cols="12" lg="1" md="1" sm="12" xs="12">
        <v-btn color="primary" @click="newProject">
          <v-icon small left>fa fa-plus</v-icon>
          <span>YENİ PROJE</span>
        </v-btn>
        <v-dialog v-model="dialog" max-width="1000px">
          <v-card>
            <v-card-title class="headline">Proje Tipi Seçiniz</v-card-title>
            <v-card-text>
              <template>
                <v-row class="ma-0">
                  <v-col class="pa-1" cols="12">
                    <v-stepper v-model="stage">
                      <v-stepper-header>
                        <v-stepper-step :complete="stage > 1" step="1">Proje Tipleri</v-stepper-step>
                        <v-divider></v-divider>
                        <v-stepper-step :complete="stage > 2" step="2">Proje Oluştur</v-stepper-step>
                        <v-divider></v-divider>
                      </v-stepper-header>
                      <v-stepper-items>
                        <v-stepper-content step="1">
                          <v-row class="ma-0">
                            <v-col cols="6">
                              <v-card class="mb-5" height="700px" color="grey lighten-1">
                                <v-row align="center" justify="center" class="ma-0">
                                  <v-col class="ma-0" cols="4">
                                    <v-img width="100%" src="@/assets/classic.png"></v-img>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" justify="center" class="ma-0" cols="12">
                                    <span class="title">Classic project</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" justify="center" class="ma-0" cols="12">
                                    <span>All the power and functionality Jira is known for. Schemes, workflows, reports, version management - it’s all here.</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="4">
                                    <span class="subtitle-2">Best for..</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="12">
                                    <span
                                      class="ml-2"
                                    >• Controlling consistency across many teams and projects.</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" justify="center" class="ml-5" cols="11">
                                    <span
                                      class="mr-2"
                                    >• Teams needing the full functionality, and configuration of classic Jira.</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="6">
                                    <span class="subtitle-2">Highlights and features</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="8">
                                    <span>Advanced and flexible configuration</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="7">
                                    <span>Highly configurable workflows</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="mr-0" cols="10">
                                    <span
                                      class="mr-2"
                                    >Configurations shared across multiple projects</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="6">
                                    <span>Over 20 different reports</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="7">
                                    <span>Hundreds of Marketplace apps</span>
                                  </v-col>
                                </v-row>
                              </v-card>
                            </v-col>
                            <v-col cols="6">
                              <v-card class="mb-5" height="700px" color="grey lighten-1">
                                <v-row align="center" justify="center" class="ma-0">
                                  <v-col class="ma-0" cols="4">
                                    <v-img width="100%" src="@/assets/classic.png"></v-img>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" justify="center" class="ma-0" cols="12">
                                    <span class="title">Next-gen project</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" justify="center" class="ml-3" cols="11">
                                    <span>A redesigned experience with fewer features and simpler configuration options than classic projects. More features coming soon.</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ml-2" cols="3">
                                    <span class="subtitle-2">Best for..</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="12">
                                    <span
                                      class="ma-0"
                                    >• Running a project autonomously, without the need of a Jira admin.</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" justify="center" class="ml-5" cols="11">
                                    <span
                                      class="mr-2"
                                    >• Teams wanting a simpler experience requiring less setup.</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="6">
                                    <span class="subtitle-2">Highlights and features</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ml-2" cols="6">
                                    <span>Streamlined configuration</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ma-0" cols="5">
                                    <span>Simple workflows</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ml-2" cols="6">
                                    <span class="mr-2">Per-project configuration</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ml-1" cols="6">
                                    <span>4 reports for agile teams</span>
                                  </v-col>
                                </v-row>
                                <v-row>
                                  <v-col align="center" class="ml-4" cols="6">
                                    <span>Dozens of Marketplace apps</span>
                                  </v-col>
                                </v-row>
                              </v-card>
                            </v-col>
                          </v-row>
                          <v-btn color="primary" @click="stage = 2">
                            <v-icon small left>fas fa-arrow-right</v-icon>
                            <span>İlerle</span>
                          </v-btn>
                        </v-stepper-content>
                        <v-stepper-content step="2">
                          <v-row class="ma-0">
                            <v-col cols="5">
                              <v-text-field
                                placeholder="Proje Adı"
                                :v-model="projectName"
                                label="Proje Adı"
                                outlined
                              ></v-text-field>
                            </v-col>
                            <v-col cols="5">
                              <v-text-field
                                placeholder="Key"
                                :v-model="projectKey"
                                label="Key"
                                outlined
                                prepend-inner-icon="fas fa-lock"
                              ></v-text-field>
                            </v-col>
                            <v-col class="mt-4" cols="1">
                              <v-icon>fas fa-info-circle</v-icon>
                            </v-col>
                          </v-row>
                          <v-row class="ma-0">
                            <v-col class="d-flex" cols="5">
                              <v-select
                                :v-model="projectType"
                                :items="selectProjectType"
                                item-text="name"
                                item-value="id"
                                label="Proje Tipi Seçiniz"
                                outlined
                              ></v-select>
                            </v-col>
                          </v-row>
                          <v-btn color="primary" @click="createProject">
                            <v-icon small left>fas fa-check-circle</v-icon>
                            <span>Oluştur</span>
                          </v-btn>
                        </v-stepper-content>
                      </v-stepper-items>
                    </v-stepper>
                  </v-col>
                </v-row>
              </template>
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="#ff4f00" @click="closeDialog" icon small>
                <v-icon dark>fas fa-window-close</v-icon>
              </v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-col>
    </v-row>
    <v-row class="ml-2">
      <v-col class="pa-1" cols="12" lg="3" md="3">
        <v-hover v-slot:default="{hover}">
          <v-card :elevation="hover? 12:2" class="white--text">
            <v-sheet color="#363636">
              <v-card-text class="pa-3">
                <v-row class="ma-0">
                  <v-col class="pa-0" cols="7">
                    <v-img width="80%" src="@/assets/jira.png"></v-img>
                  </v-col>
                  <v-col class="pa-0 text-right" cols="5">
                    <v-btn icon small>
                      <v-icon color="white">fa fa-star</v-icon>
                    </v-btn>
                  </v-col>
                </v-row>
              </v-card-text>
            </v-sheet>
            <v-sheet color="#0866C6">
              <v-card-text class="pa-8">
                <v-row class="pa-1">
                  <v-col class="pa-0" cols="12" md="5" sm="12" xs="12">
                    <v-btn icon x-large>
                      <v-icon size="45" color="white">fas fa-folder</v-icon>
                    </v-btn>
                  </v-col>
                  <v-col cols="12" md="7" sm="12" xs="12" class="pa-0">
                    <h1 class="title white--text">Jira Project</h1>
                    <h1 class="subtitle-1 white--text">Software Project</h1>
                  </v-col>
                </v-row>
              </v-card-text>
            </v-sheet>
          </v-card>
        </v-hover>
      </v-col>
      <v-col class="pa-1" cols="12" lg="3" md="3">
        <v-hover v-slot:default="{hover}">
          <v-card :elevation="hover? 12:2" class="white--text">
            <v-sheet color="#363636">
              <v-card-text class="pa-3">
                <v-row class="ma-0">
                  <v-col class="pa-0" cols="7">
                    <v-img width="80%" src="@/assets/jira.png"></v-img>
                  </v-col>
                  <v-col class="pa-0 text-right" cols="5">
                    <v-btn icon small>
                      <v-icon color="white">fa fa-star</v-icon>
                    </v-btn>
                  </v-col>
                </v-row>
              </v-card-text>
            </v-sheet>
            <v-sheet color="#00b297">
              <v-card-text class="pa-8">
                <v-row class="pa-1">
                  <v-col class="pa-0" cols="12" md="5" sm="12" xs="12">
                    <v-btn icon x-large>
                      <v-icon size="45" color="white">fas fa-folder</v-icon>
                    </v-btn>
                  </v-col>
                  <v-col cols="12" md="7" sm="12" xs="12" class="pa-0">
                    <h1 class="title white--text">Jira Project</h1>
                    <h1 class="subtitle-1 white--text">Software Project</h1>
                  </v-col>
                </v-row>
              </v-card-text>
            </v-sheet>
          </v-card>
        </v-hover>
      </v-col>
      <v-col class="pa-1" cols="12" lg="3" md="3">
        <v-hover v-slot:default="{hover}">
          <v-card :elevation="hover? 12:2" class="white--text">
            <v-sheet color="#363636">
              <v-card-text class="pa-3">
                <v-row class="ma-0">
                  <v-col class="pa-0" cols="7">
                    <v-img width="80%" src="@/assets/jira.png"></v-img>
                  </v-col>
                  <v-col class="pa-0 text-right" cols="5">
                    <v-btn icon small>
                      <v-icon color="white">fa fa-star</v-icon>
                    </v-btn>
                  </v-col>
                </v-row>
              </v-card-text>
            </v-sheet>
            <v-sheet color="#ff4f00">
              <v-card-text class="pa-8">
                <v-row class="pa-1">
                  <v-col class="pa-0" cols="12" md="5" sm="12" xs="12">
                    <v-btn icon x-large>
                      <v-icon size="45" color="white">fas fa-folder</v-icon>
                    </v-btn>
                  </v-col>
                  <v-col cols="12" md="7" sm="12" xs="12" class="pa-0">
                    <h1 class="title white--text">Jira Project</h1>
                    <h1 class="subtitle-1 white--text">Software Project</h1>
                  </v-col>
                </v-row>
              </v-card-text>
            </v-sheet>
          </v-card>
        </v-hover>
      </v-col>
    </v-row>
    <v-row class="mt-6">
      <v-divider></v-divider>
    </v-row>
    <v-card class="ma-12">
      <v-row>
        <div class="black"></div>
      </v-row>
      <template>
        <v-card>
          <v-card-text>
            <v-row>
              <v-col cols="12">
                <v-col cols="12">
                  <v-row>
                    <v-col cols="6">
                      <v-btn fab dark color="#0866C6">
                        <v-icon dark>fa fa-plus</v-icon>
                      </v-btn>
                    </v-col>
                    <v-col cols="6">
                      <v-text-field
                        class="d-flex flex-row-reverse"
                        v-model="search"
                        append-icon="fas fa-search"
                        label="Search"
                        single-line
                        hide-details
                      ></v-text-field>
                    </v-col>
                  </v-row>
                </v-col>
                <v-col cols="12">
                  <v-data-table
                    :headers="headers"
                    :items="desserts"
                    sort-by="calories"
                    class="elevation-1 data-table"
                    :search="search"
                  >
                    <template v-slot:item.actions="{ item }">
                      <v-btn class="ma-1" small style="background-color:#0866C6">
                        <v-icon color="white" small @click="editItem(item)">fa fa-edit</v-icon>
                      </v-btn>
                      <v-btn class="ma-1" small style="background-color:red">
                        <v-icon color="white" small @click="deleteItem(item)">fa fa-trash</v-icon>
                      </v-btn>
                      <v-btn class="ma-1" small style="background-color:green">
                        <v-icon color="white" small @click="goProject(item)">fa fa-share</v-icon>
                      </v-btn>
                    </template>
                  </v-data-table>
                </v-col>
              </v-col>
            </v-row>
          </v-card-text>
        </v-card>
      </template>
    </v-card>
  </v-container>
</template>

<script>
export default {
  data: () => ({
    search: '',
    time: Date.now(),
    stage: 1,
    dialog: false,
    projectName: "",
    selectProjectType: [],
    projectType: {},
    projectKey: "",
    headers: [
      {
        text: "Dessert (100g serving)",
        align: "start",
        sortable: false,
        value: "name",
        class: "black--text"
      },
      { class: "black--text", text: "Calories", value: "calories" },
      { class: "black--text", text: "Fat (g)", value: "fat" },
      { class: "black--text", text: "Carbs (g)", value: "carbs" },
      { class: "black--text", text: "Protein (g)", value: "protein" },
      {
        class: "black--text",
        text: "Actions",
        value: "actions",
        sortable: false
      }
    ],
    desserts: [
      {
        name: "Frozen Yogurt",
        calories: 159,
        fat: 6.0,
        carbs: 24,
        protein: 4.0
      },
      {
        name: "Frozen Yogurt",
        calories: 159,
        fat: 6.0,
        carbs: 24,
        protein: 4.0
      },
      {
        name: "Frozen Yogurt",
        calories: 159,
        fat: 6.0,
        carbs: 24,
        protein: 4.0
      },
      {
        name: "Frozen Yogurt",
        calories: 159,
        fat: 6.0,
        carbs: 24,
        protein: 4.0
      },
      {
        name: "Frozen Yogurt",
        calories: 159,
        fat: 6.0,
        carbs: 24,
        protein: 4.0
      },
      {
        name: "Frozen Yogurt",
        calories: 159,
        fat: 6.0,
        carbs: 24,
        protein: 4.0
      }
    ]
  }),

  methods: {
    newProject() {
      this.dialog = true;
    },

    createProject() {
      this.dialog = false;
      this.stage = 1;
    },

    closeDialog() {
      this.dialog = false;
    },

    deleteItem() {
      //
    },

    editItem() {
      //
    },

    goProject() {
      //
    }
  }
};
</script>

<style scoped>
.card-background {
  background-color: #0866c6;
}
</style>