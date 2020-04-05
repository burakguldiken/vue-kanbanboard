import Toolbar from "../components/Toolbar";
import Sidebar from "../components/Sidebar";
import Footer from "../components/Footer";
import MaterialChartCard from "../components/MaterialChartCard";


import VueSweetalert2 from 'vue-sweetalert2';
import "sweetalert2/dist/sweetalert2.css";

import moment from 'moment'

import 'vue-loaders/dist/vue-loaders.css';
import VueLoaders from 'vue-loaders';

function setupComponents(Vue){
    Vue.component('toolbar', Toolbar);
    Vue.component('sidebar', Sidebar);
    Vue.component("pagefooter", Footer);
    Vue.component("materialchartcard", MaterialChartCard);

    Vue.use(VueSweetalert2);

    Vue.use(require('vue-moment'));
    Vue.prototype.moment = moment
    moment.locale('tr');

    Vue.use(VueLoaders);
}

export {
    setupComponents
}