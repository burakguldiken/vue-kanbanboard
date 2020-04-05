<template>
  <v-container>
    <v-row>
        <v-col class="" cols="3">
          <widget icon="fa fa-users" title="1,287,687" subTitle= 'Toplam Kullanıcı' supTitle="Adet Kullanıcı" color="#00b297"/>
        </v-col>
        <v-col class="" cols="3">
          <widget icon="fa fa-tasks" title="1,287,687" subTitle= 'Size Tahsis Edilen Task' supTitle="Adet Task" color="#dc3545"/>
        </v-col>
        <v-col class="" cols="3">
          <widget icon="fas fa-spinner fa-spin" title="1,287,687" subTitle= 'Bekleyen Task' supTitle="Adet Task" color="#0866C6"/>
        </v-col>
        <v-col class="" cols="3">
          <widget icon="fa-check-circle" title="1,287,687" subTitle= 'Tamamlanan Task' supTitle="Adet Task" color="#1D2939"/>
        </v-col>
      </v-row>
      <v-row class="mt-8">
        <v-col cols="6">
          <v-card>
            <apexcharts class="donut" type="pie" width="580" :options="chartOptions" :series="series"></apexcharts>
            <v-card-text class="pt-0">
              <div class="title font-weight-light mb-2 black--text">Task Distribution Schema</div>
              <div class="subheading font-weight-light black--text">Tasks</div>
              <v-divider class="my-2"></v-divider>
              <v-icon class="mr-2" small>mdi-clock</v-icon>
              <span class="caption black--text font-weight-light">last updated 26 minutes ago</span>
            </v-card-text>
          </v-card>
        </v-col>
        <v-col cols="6">
          <v-card class="mx-auto white" height="510">
            <div class="title font-weight-light pa-2 white--text" style="background-color:green">Activities</div>
            <v-divider></v-divider>
        <v-card-text class="py-0">
          <v-timeline align-top dense>
            <v-timeline-item color="black" small>
              <v-row class="pt-">
                <v-col cols="3">
                  <strong>5pm</strong>
                </v-col>
                <v-col>
                  <strong>New Icon</strong>
                  <div class="caption">Mobile App</div>
                </v-col>
              </v-row>
            </v-timeline-item>

            <v-timeline-item color="red" small>
              <v-row class="pt-1">
                <v-col cols="3">
                  <strong>3-4pm</strong>
                </v-col>
                <v-col>
                  <strong>Design Stand Up</strong>
                </v-col>
              </v-row>
            </v-timeline-item>

            <v-timeline-item color="blue" small>
              <v-row class="pt-1">
                <v-col cols="3">
                  <strong>12pm</strong>
                </v-col>
                <v-col>
                  <strong>Lunch break</strong>
                </v-col>
              </v-row>
            </v-timeline-item>

            <v-timeline-item color="purple" small>
              <v-row class="pt-1">
                <v-col cols="3">
                  <strong>9-11am</strong>
                </v-col>
                <v-col>
                  <strong>Finish Home Screen</strong>
                  <div class="caption">Web App</div>
                </v-col>
              </v-row>
            </v-timeline-item>
            
            <v-timeline-item class="pb-2" color="yellow" small>
              <v-row class="pt-1">
                <v-col cols="3">
                  <strong>9-11am</strong>
                </v-col>
                <v-col>
                  <strong>Finish Home Screen</strong>
                  <div class="caption">Web App</div>
                </v-col>
              </v-row>
            </v-timeline-item>
          </v-timeline>
        </v-card-text>
      </v-card>
        </v-col>
      </v-row>
  </v-container>
</template>

<script>
import VueApexCharts from "vue-apexcharts";
import widget from '../home/Widget';

export default {
  name: "Chart",
  components: {
    apexcharts: VueApexCharts,
    widget
  },
  data: function() {
    return {
      series: [25, 50, 18, 43],
          chartOptions: {
            chart: {
              width: 380,
              type: 'pie',
            },
            labels: ['Backlog', 'Selected Development', 'In Progress', 'Done'],
            responsive: [{
              breakpoint: 480,
              options: {
                chart: {
                  width: 200
                },
                legend: {
                  position: 'bottom'
                }
              }
            }]
          }
    };
  },
  methods: {
    
  },
};
</script>
<style scoped>
.donut {
  border-radius: 50px;
}
.apex {
  color: black;
}
.v-sheet--offset {
  top: -24px;
  position: relative;
  background-color: white;
}
.v-sheet--offset-1 {
  top: -24px;
  position: relative;
  background-color: rgb(233, 30, 99);
}
.v-sheet--offset-2 {
  top: -24px;
  position: relative;
  background-color: #00cae3;
}
</style>