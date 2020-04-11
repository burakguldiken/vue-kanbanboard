<template>
  <v-container fill-height fluid grid-list-xl>
    <v-layout justify-center wrap>
      <v-flex xs12 md8>
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
                <v-textarea
                  solo
                  outlined
                  loading
                  label="About"
                ></v-textarea>
              </v-col>
            </v-row>
          </v-form>
          <v-row class="ml-6">
            <v-btn rounded large
              color="#0866C6"
            >
            <v-icon class="mr-2" style="color:white">fa fa-check-circle</v-icon>
            <span class="white--text">Save</span>
            </v-btn>
          </v-row>
          </v-card-text>
        </v-card>
      </v-flex>
      <v-flex xs12 md4>
        <v-card>
            <v-card-text>
                <v-row>
                    <v-avatar class="text-center avatar" color="indigo" size="150">
                    <v-icon dark>fa fa-user</v-icon>
                </v-avatar>
                </v-row>
                <v-row>
                    <span class="headline black--text" style="margin-left:178px; margin-top:30px">Burak Güldiken</span>
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
            <v-rating
              v-model="rating"
              background-color="red lighten-3"
              color="#dc3545"
              small
            ></v-rating>
            </v-card-text>
                   
            </v-card-text>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  data () {
      return {
        value: 0,
        query: false,
        show: true,
        interval: 20,
        rating:5,
      }
    },

    mounted () {
      this.queryAndIndeterminate()
    },

    beforeDestroy () {
      clearInterval(this.interval)
    },

    methods: {
      queryAndIndeterminate () {
        this.query = true
        this.show = true
        this.value = 0

        setTimeout(() => {
          this.query = false

          this.interval = setInterval(() => {
            if (this.value === 100) {
              clearInterval(this.interval)
              this.show = false
              return setTimeout(this.queryAndIndeterminate, 2000)
            }
            this.value += 25
          }, 1000)
        }, 2500)
      },
    },
}
</script>

<style scoped>
.avatar {
    margin-left: 180px;;
}
.divider {
    border-top: 1px solid grey;
    margin-top: 50px;
    margin-left: 3px;
    margin-right: 3px;
}
</style>

