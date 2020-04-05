<template>
  <v-container fill-height>
    <v-row align="center" justify="center">      
      <v-col cols="12" class="text-center pa-1">
        <v-icon size="128" color="primary">fa fa-times</v-icon>
      </v-col>
      <v-col cols="12" class="text-center pa-1">
        <span class="title">Üzgünüz Bu Sayfayı Bulamadık!</span>
        <br />
        <span class="title">Aradığınız Sayfa Mevcut Değil!</span>
      </v-col>
      <v-col cols="12" class="text-center">
        <span class="subtitle-1 link" @click="$router.push({path:'/'})">Anasayfa</span>
      </v-col>
    </v-row>
  </v-container>
</template>

<style scoped>
.link {
  cursor: pointer;
}
</style>