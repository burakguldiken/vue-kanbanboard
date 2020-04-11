<template>
<div>
  <v-btn class="ma-4" color="primary" @click="openTaskDialog">
        <v-icon small left>fa fa-plus</v-icon>
        <span>YENİ</span>
  </v-btn>
  <v-dialog v-model="dialog" max-width="800px">
        <v-card>
            <v-card-title class="headline">Yeni Task Oluştur</v-card-title>
            <v-card-text>
                <v-row class="ma-0">
                    <v-col cols="4">
                        <v-select
                            :items="selectProject"
                            item-text="name"
                            item-value="id"
                            label="Proje Seçiniz"
                            dense
                            outlined
                        ></v-select>
                    </v-col>
                </v-row>
                <v-row class="ma-0">
                    <v-col cols="4">
                        <v-select
                            :v-model="taskType"
                            :items="selectTaskType"
                            item-text="name"
                            item-value="id"
                            label="Task Tipi Seçiniz"
                            dense
                            outlined
                        ></v-select>
                    </v-col>
                    <v-col class="mt-2" cols="1">
                      <v-icon medium @click="typeInfo">fas fa-question-circle</v-icon>
                    </v-col>
                </v-row>
                <v-row class="ma-0">
                    <v-col cols="12">
                        <v-text-field
                            placeholder="Açıklama"
                            :v-model="summary"
                            label="Açıklama"
                            outlined
                        ></v-text-field>
                    </v-col>
                </v-row>
                <v-row class="ma-0">
                    <v-col cols="12">
                        <v-text-field
                            placeholder="Oluşturan"
                            :v-model="reporter"
                            label="Oluşturan"
                            outlined
                        ></v-text-field>
                    </v-col>
                </v-row>
                <v-row class="ma-0">
                  <v-col cols="12">
                    <vue-editor v-model="description"></vue-editor>
                  </v-col>
                </v-row>
                <v-row class="ma-0">
                  <v-col cols="4">
                    <v-select
                      :v-model="priority"
                      :items="priorityItems"
                      item-text="name"
                      item-value="id"
                      label="Priority"
                      dense
                      outlined
                    ></v-select>
                  </v-col>
                </v-row>
                <v-row class="ma-0">
                  <v-col cols="4">
                    <v-select
                      :v-model="user"
                      :items="teamUsers"
                      item-text="name"
                      item-value="id"
                      label="Assign"
                      dense
                      outlined
                    ></v-select>
                  </v-col>
                  <v-col class="mt-2" cols="1">
                    <v-icon medium @click="typeInfo">fas fa-question-circle</v-icon>
                  </v-col>
                </v-row>
                <v-row class="ma-0">
                  <v-btn class="ma-4" color="primary" @click="newTask">
                      <v-icon small left>fas fa-check-circle</v-icon>
                      <span>Oluştur</span>
                </v-btn>
                </v-row>
            </v-card-text>
            <v-card-actions>

            </v-card-actions>
        </v-card>
  </v-dialog>
  <div class="drag-container" v-drag-and-drop:options="options">
    <ul class="drag-list">
      <li class="drag-column" v-for="group in groups" :key="group.id">
        <span class="drag-column-header">
          <v-row>
            <v-col cols="12">
              <v-card style="background:black">
                <v-card-text align="center" justify="center">
                  <h2 class="white--text">{{ group.name }}</h2>
                </v-card-text>
              </v-card>
            </v-col>
          </v-row>
        </span>
        <vue-draggable-group
          v-model="group.items"
          :groups="groups"
          :data-id="group.id"
          @change="onGroupsChange"
        >
          <ul class="drag-inner-list" :data-id="group.id">
            <li class="drag-item" v-for="item in group.items" :key="item.id" :data-id="item.id">
              <div class="drag-item-text">{{ item.name }}</div>
              <div class="dot-class">
                <v-icon style="color:yellow" @click="newTask" small class="mt-4 ml-3">fas fa-check-circle</v-icon>
                <v-icon style="color:#ff4f00" @click="newTask" small class="mt-4 ml-2" dark>fas fa-arrow-up</v-icon>
                <v-icon style="color:#00b297" @click="newTask" small class="mt-4 ml-2" dark>fas fa-ellipsis-h</v-icon>
              </div>
            </li>
          </ul>
        </vue-draggable-group>
      </li>
    </ul>
  </div>
</div>
</template>

<script>
import { VueEditor } from 'vue2-editor'
export default {
  components: {
      VueEditor
   },
  data() {
    return {
      dialog: false,
      selectProject: [],
      selectTaskType: [],
      taskType: {},
      summary: '',
      reporter: '',
      description: '',
      priorityItems: [],
      priority: {},
      teamUsers: [],
      user: {},
      groups: [
        {
          id: 1,
          name: "Backlog",
          items: [
            { id: 1, name: "Item 1", groupId: 1 },
            { id: 2, name: "Item 2", groupId: 1 },
            { id: 3, name: "Item 3", groupId: 1 }
          ]
        },
        {
          id: 2,
          name: "Selected Development",
          items: [
            { id: 4, name: "Item 2", groupId: 2 },
            { id: 5, name: "Item 3", groupId: 2 },
            { id: 6, name: "Item 4", groupId: 2 }
          ]
        },
        {
          id: 3,
          name: "In Progress",
          items: [
            { id: 7, name: "Item 5", groupId: 3 },
            { id: 8, name: "Item 6", groupId: 3 },
            { id: 9, name: "Item 7", groupId: 3 }
          ]
        },
        {
          id: 4,
          name: "Done",
          items: [
            { id: 10, name: "Item 8", groupId: 4 },
            { id: 11, name: "Item 9", groupId: 4 },
            { id: 12, name: "Item 10", groupId: 4 },
            { id: 13, name: "Item 11", groupId: 4 }
          ]
        }
      ],
      options: {
        dropzoneSelector: ".drag-inner-list",
        draggableSelector: ".drag-item"
      }
    };
  },
  methods: {
    onGroupsChange(e) {
      window.console.log({ e });
    },

    openTaskDialog() {
        this.dialog = true;
    },

    newTask() {
      this.dialog = false;
    },

    typeInfo() {
      //
    }
  }
};
</script>

<style lang="scss">
$ease-out: all 0.3s cubic-bezier(0.23, 1, 0.32, 1);
$to-do: #f4ce46;
$selected-development: #f4ce46;
$in-progress: #2a92bf;
$approved: #00b961;

* {
  box-sizing: border-box;
}

dot-class{
    margin: 10px;
}

body {
  background: #33363d;
  color: white;
  font-family: "Roboto Mono", serif;
  font-weight: 300;
  line-height: 1.5;
  -webkit-font-smoothing: antialiased;
}

ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
}

.drag-container {
  max-width: 1500px;
  margin: 20px auto;
}

.drag-list {
  display: flex;
  align-items: flex-start;

  @media (max-width: 690px) {
    display: block;
  }
}

.drag-column {
  flex: 1;
  margin: 0 2px;
  position: relative;
  background: rgba(rgb(146, 138, 138), 0.2);
  overflow: hidden;

  @media (max-width: 690px) {
    margin-bottom: 30px;
  }

  h2 {
    font-size: 0.8rem;
    margin: 0;
    text-transform: uppercase;
    font-weight: 600;
  }

  &-to-do {
    .drag-column-header,
    .drag-options {
      background: $to-do;
    }
  }

  &-selected-development {
    .drag-column-header,
    .drag-options {
      background: $selected-development;
    }
  }

  &-in-progress {
    .drag-column-header,
    .drag-options {
      background: $in-progress;
    }
  }

  &-approved {
    .drag-column-header,
    .drag-options {
      background: $approved;
    }
  }
}

.drag-column-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px;
  user-select: none;
}

.drag-inner-list {
  height: 85vh;
  overflow: auto;
}

.drag-item {
  border-radius: 8px;
  margin-right: 15px;
  margin-top: 10px;
  height: 80px;
  background: rgba(rgb(49, 61, 236), 0.8);
  transition: $ease-out;

  /* items grabbed state */
  &[aria-grabbed="true"] {
    background: #415ae7;
    color: white;
  }

  .drag-item-text {
    font-size: 1rem;
    padding-left: 1rem;
    padding-top: 1rem;
    color:white;
  }
}

.drag-item:hover {
  background-color: #0000FF;
  border: 2px solid black;
}

.drag-header-more {
  cursor: pointer;
}

@keyframes nodeInserted {
  from {
    opacity: 0.2;
  }
  to {
    opacity: 0.8;
  }
}

.item-dropzone-area {
  height: 6rem;
  background:white;
  opacity: 0.8;
  animation-duration: 0.5s;
  animation-name: nodeInserted;
  margin-left: 0.6rem;
  margin-right: 0.6rem;
}
</style>
