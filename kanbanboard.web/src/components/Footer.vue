<template>
  <v-footer app inset class="transparent">
    <v-col class="text-left" cols="12">
      <span class="black--text">
        {{ new Date().getFullYear() }} —
        <strong>Kanban Board</strong>
      </span>
    </v-col>
  </v-footer>
</template>


<style scoped>
.transparent {
  background-color: white !important;
  opacity: 0.65;
  border-color: transparent !important;
}
</style>