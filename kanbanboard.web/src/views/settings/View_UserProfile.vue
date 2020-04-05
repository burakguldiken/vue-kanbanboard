<template>
  <v-container fill-height fluid grid-list-xl>
    <v-layout justify-center wrap>
      <v-flex xs12 md8>
        <v-card>
            <!-- Güncelleme cardı gelecek -->
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

            <v-btn
              color="success"
              rounded
              class="mr-0"
            >
              Follow
            </v-btn>
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

