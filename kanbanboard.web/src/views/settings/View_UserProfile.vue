<template>
  <v-container>
    <v-row align="center" justify="center">
      <v-col cols="11">
        <v-card class="mx-auto" max-width="1500">
          <v-img class="white--text" height="350px" src="@/assets/profil.jpg"></v-img>
        </v-card>
      </v-col>
    </v-row>
    <v-row justify="center">
      <v-col cols="4">
        <v-card>
          <v-card-text>
            <v-row justify="center">
              <v-avatar class="text-center avatar" color="indigo" size="150">
                <v-icon dark>fa fa-user</v-icon>
              </v-avatar>
            </v-row>
            <v-row>
              <span
                class="headline black--text"
                style="margin-left:178px; margin-top:30px"
              >Burak Güldiken</span>
            </v-row>
            <v-card class="mt-12">
              <div style="min-height: 4px;">
                <v-progress-linear
                  v-model="value"
                  :active="show"
                  :indeterminate="query"
                  :query="true"
                ></v-progress-linear>
              </div>
            </v-card>
            <v-card-text>
              <p class="font-weight-light grey--text">
                Don't be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...
                Don't be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...
              </p>
              <v-rating v-model="rating" background-color="red lighten-3" color="#dc3545" small></v-rating>
            </v-card-text>
          </v-card-text>
        </v-card>
      </v-col>
      <v-col cols="7">
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
              <v-icon class="mr-1">fa fa-user-circle</v-icon>
              <span class="white--text ml-3">User Profile</span>
            </v-tab>
            <v-tab>
              <v-icon class="mr-3" style="color:white">fas fa-project-diagram</v-icon>
              <span class="white--text">Projects</span>
            </v-tab>

            <v-tab-item>
              <v-card>
                <v-card-text>
                  <v-row>
                    <v-col cols="2" class="ma-3">
                      <v-card style="background:#dc3545">
                        <v-card-text align="center" justify="center">
                          <v-icon x-large dark>fa fa-users</v-icon>
                        </v-card-text>
                      </v-card>
                    </v-col>
                  </v-row>
                  <v-form v-model="validUserForm">
                    <v-row class="mt-3 ml-3">
                      <v-col cols="6">
                        <v-text-field
                          solo
                          outlined
                          loading
                          label="Name"
                          prepend-inner-icon="fa fa-user"
                        ></v-text-field>
                      </v-col>
                      <v-col cols="6">
                        <v-text-field
                          solo
                          outlined
                          loading
                          label="Surname"
                          prepend-inner-icon="fa fa-user"
                        ></v-text-field>
                      </v-col>
                      <v-col cols="6">
                        <v-text-field
                          solo
                          outlined
                          loading
                          label="Email"
                          prepend-inner-icon="fas fa-envelope"
                        ></v-text-field>
                      </v-col>
                      <v-col cols="6">
                        <v-text-field
                          solo
                          outlined
                          loading
                          label="Phone"
                          prepend-inner-icon="fas fa-phone"
                        ></v-text-field>
                      </v-col>
                      <v-col cols="6">
                        <v-text-field
                          solo
                          outlined
                          loading
                          label="Password"
                          prepend-inner-icon="fa fa-lock"
                        ></v-text-field>
                      </v-col>
                      <v-col cols="6">
                        <v-text-field
                          solo
                          outlined
                          loading
                          label="Password(Again)"
                          prepend-inner-icon="fa fa-lock"
                        ></v-text-field>
                      </v-col>
                      <v-col cols="12">
                        <v-textarea solo outlined loading label="About"></v-textarea>
                      </v-col>
                    </v-row>
                  </v-form>
                  <v-row class="ml-6">
                    <v-btn medium color="#0866C6">
                      <v-icon class="mr-2" style="color:white">fa fa-check-circle</v-icon>
                      <span class="white--text">Save</span>
                    </v-btn>
                  </v-row>
                </v-card-text>
              </v-card>
            </v-tab-item>
            <v-tab-item>
              <v-row>
                <v-col cols="6">
                  <v-card class="mx-auto" max-width="400">
                    <v-img
                      class="white--text align-end"
                      height="200px"
                      src="@/assets/p1.jpg"
                    >
                      <v-card-title>Top 10 Australian beaches</v-card-title>
                    </v-img>

                    <v-card-subtitle class="pb-0">Number 10</v-card-subtitle>

                    <v-card-text class="text--primary">
                      <div>Whitehaven Beach</div>

                      <div>Whitsunday Island, Whitsunday Islands</div>
                    </v-card-text>

                    <v-card-actions>
                      <v-btn small style="background-color:red">
                        <v-icon small style="color:white">fa fa-heart</v-icon>
                      </v-btn>

                      <v-btn small style="background-color:#0866C6">
                        <v-icon small style="color:white">far fa-thumbs-up</v-icon>
                      </v-btn>
                    </v-card-actions>
                  </v-card>
                </v-col>
                <v-col cols="6">
                  <v-card class="mx-auto" max-width="400">
                    <v-img
                      class="white--text align-end"
                      height="200px"
                      src="@/assets/p2.jpg"
                    >
                      <v-card-title>Top 10 Australian beaches</v-card-title>
                    </v-img>

                    <v-card-subtitle class="pb-0">Number 10</v-card-subtitle>

                    <v-card-text class="text--primary">
                      <div>Whitehaven Beach</div>

                      <div>Whitsunday Island, Whitsunday Islands</div>
                    </v-card-text>

                    <v-card-actions>
                      <v-btn small style="background-color:red">
                        <v-icon small style="color:white">fa fa-heart</v-icon>
                      </v-btn>

                      <v-btn small style="background-color:#0866C6">
                        <v-icon small style="color:white">far fa-thumbs-up</v-icon>
                      </v-btn>
                    </v-card-actions>
                  </v-card>
                </v-col>
                <v-col cols="6">
                  <v-card class="mx-auto" max-width="400">
                    <v-img
                      class="white--text align-end"
                      height="200px"
                      src="@/assets/p2.jpg"
                    >
                      <v-card-title>Top 10 Australian beaches</v-card-title>
                    </v-img>

                    <v-card-subtitle class="pb-0">Number 10</v-card-subtitle>

                    <v-card-text class="text--primary">
                      <div>Whitehaven Beach</div>

                      <div>Whitsunday Island, Whitsunday Islands</div>
                    </v-card-text>

                    <v-card-actions>
                      <v-btn small style="background-color:red">
                        <v-icon small style="color:white">fa fa-heart</v-icon>
                      </v-btn>

                      <v-btn small style="background-color:#0866C6">
                        <v-icon small style="color:white">far fa-thumbs-up</v-icon>
                      </v-btn>
                    </v-card-actions>
                  </v-card>
                </v-col>
              </v-row>
            </v-tab-item>
          </v-tabs>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      value: 0,
      query: false,
      show: true,
      interval: 20,
      rating: 5,
      tab: 1,
      icons: false,
      centered: false,
      grow: true,
      vertical: false,
      prevIcon: true,
      nextIcon: true,
      right: false,
      validUserForm: false
    };
  },

  mounted() {
    this.queryAndIndeterminate();
  },

  beforeDestroy() {
    clearInterval(this.interval);
  },

  methods: {
    queryAndIndeterminate() {
      this.query = true;
      this.show = true;
      this.value = 0;

      setTimeout(() => {
        this.query = false;

        this.interval = setInterval(() => {
          if (this.value === 100) {
            clearInterval(this.interval);
            this.show = false;
            return setTimeout(this.queryAndIndeterminate, 2000);
          }
          this.value += 25;
        }, 1000);
      }, 2500);
    }
  }
};
</script>