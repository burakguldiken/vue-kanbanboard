<template>
  <v-container fill-height fluid grid-list-xl>
    <v-layout justify-center wrap>
      <v-row justify="center">
        <v-col cols="4">
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
            <v-tabs-slider></v-tabs-slider>

            <v-tab v-for="i in tabs" :key="i" :href="`#tab-${i}`">
              <v-badge v-if="i === 1" class="mt-2" color="red" content="6">
                <v-icon>fas fa-inbox</v-icon>
              </v-badge>
              <v-badge v-if="i === 2" class="mt-2" color="red" content="21">
                <v-icon>fas fa-inbox</v-icon>
              </v-badge>
              <span class="ml-6" v-if="i === 1">GİDEN KUTUSU</span>
              <span class="ml-6" v-else>GELEN KUTUSU</span>
            </v-tab>

            <v-tab-item v-for="i in tabs" :key="i" :value="'tab-' + i">
              <v-card class="ma-3" v-for="item in cardItems" :key="item.id">
                <v-sheet class="card" v-if="i === 1">
                  <v-card-text class="pa-8">
                    <v-row>
                      <v-col cols="4">
                        <v-btn icon x-large>
                          <v-icon medium color="black">fas fa-envelope-open</v-icon>
                        </v-btn>
                      </v-col>
                      <v-col cols="2" md="7" sm="12" xs="12" class="pa-0">
                        <h1 class="title red--text">Jira Project</h1>
                        <h1
                          class="subtitle-1 black--text test"
                        >Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek</h1>
                      </v-col>
                    </v-row>
                  </v-card-text>
                  <v-card-actions>
                    <v-row class="d-flex flex-row-reverse mr-3">
                      <v-btn class="ml-1" small style="background-color:red">
                        <v-icon small style="color:white">fa fa-heart</v-icon>
                      </v-btn>
                      <v-btn small style="background-color:#0866C6">
                        <v-icon small style="color:white">fas fa-trash-alt</v-icon>
                      </v-btn>
                    </v-row>
                  </v-card-actions>
                </v-sheet>
              </v-card>
              <v-card class="ma-3" v-for="item in cardItems" :key="item.id">
                <v-sheet class="card" v-if="i === 2">
                  <v-card-text class="pa-8">
                    <v-row>
                      <v-col cols="4">
                        <v-btn icon x-large>
                          <v-icon medium color="black">fas fa-envelope-open</v-icon>
                        </v-btn>
                      </v-col>
                      <v-col cols="2" md="7" sm="12" xs="12" class="pa-0">
                        <h1 class="title red--text">Jira Project</h1>
                        <h1
                          class="subtitle-1 black--text test"
                        >Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek</h1>
                      </v-col>
                    </v-row>
                  </v-card-text>
                  <v-card-actions>
                    <v-row class="d-flex flex-row-reverse mr-3">
                      <v-btn class="ml-1" small style="background-color:red">
                        <v-icon small style="color:white">fa fa-heart</v-icon>
                      </v-btn>
                      <v-btn small style="background-color:#0866C6">
                        <v-icon small style="color:white">fas fa-trash-alt</v-icon>
                      </v-btn>
                    </v-row>
                  </v-card-actions>
                </v-sheet>
              </v-card>
            </v-tab-item>
          </v-tabs>
        </v-col>
        <v-col cols="7">
          <v-card>
            <v-card-text>
              <v-row align="center" justify="center">
                <v-col cols="11">
                  <v-card class="mx-auto" width="900">
                    <v-img height="300px" src="@/assets/m10.png"></v-img>
                  </v-card>
                </v-col>
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
              <v-form v-model="validNotificationForm">
                <v-row class="mt-12">
                  <v-col cols="6">
                    <v-text-field
                      solo
                      outlined
                      loading
                      label="Gönderen"
                      prepend-inner-icon="fa fa-share"
                    ></v-text-field>
                  </v-col>
                  <v-col cols="6">
                    <v-text-field
                      solo
                      outlined
                      loading
                      label="Alıcı"
                      prepend-inner-icon="fa fa-share"
                    ></v-text-field>
                  </v-col>
                  <v-col cols="12">
                    <v-textarea
                      solo
                      outlined
                      loading
                      label="Açıklama"
                      prepend-inner-icon="fas fa-comments"
                    ></v-textarea>
                  </v-col>
                  <v-col cols="3">
                    <v-btn medium color="#0866C6">
                      <v-icon class="mr-3" style="color:white">fas fa-check-circle</v-icon>
                      <span class="white--text">Gönder</span>
                    </v-btn>
                  </v-col>
                </v-row>
              </v-form>
            </v-card-text>
          </v-card>
        </v-col>
      </v-row>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      validNotificationForm: false,
      value: 0,
      query: true,
      show: true,
      interval: 20,
      tab: 2,
      text: "Test",
      icons: false,
      centered: false,
      grow: true,
      vertical: false,
      prevIcon: false,
      nextIcon: false,
      right: false,
      tabs: 2,
      cardItems: [
        {
          id: 1,
          title: "Deneme123"
        },
        {
          id: 2,
          title: "Deneme1234"
        },
        {
          id: 3,
          title: "Deneme123"
        },
        {
          id: 4,
          title: "Deneme1234"
        }
      ]
    };
  }
};
</script>

<style scoped>
.test {
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

.card {
  border: rgb(74, 212, 74) 1px solid;
}

.card:hover {
  background-color: rgb(29, 202, 136);
}

.image {
  height: 50%;
  width: 50%;
}

.lightbox {
  box-shadow: 0 0 20px inset rgba(0, 0, 0, 0.2);
  background-image: linear-gradient(
    to top,
    rgba(0, 0, 0, 0.4) 0%,
    transparent 72px
  );
}
</style>