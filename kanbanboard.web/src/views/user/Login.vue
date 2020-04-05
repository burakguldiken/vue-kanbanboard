<template>
  <v-container fluid>
    <v-row>
      <v-img class="ma-0" :aspect-ratio="16/9" src="">
      <v-row align="right" justify="center" class="ma-12">
        <v-col cols="12" lg="3" md="6" sm="12" xs="12">
          <v-hover v-slot:default="{hover}">
            <v-card :elevation="hover ? 12 : 2" height="700px">
              <v-toolbar color="black">
                <v-col cols="12" class="align-center pa-12">
                  <v-img class="ma-12" src="@/assets/jira.png"></v-img>
                </v-col>
              </v-toolbar>
              <v-card-text>
                <v-form v-model="valid" @submit="login">
                  <v-row>
                    <v-col cols="12" lg="12" md="12" sm="12" xs="12" class="text-center mt-8 mb-8">
                      <span class="subtitle-1 black--text">Kullanıcı Girişi</span>
                    </v-col>
                    <v-row class="ma-1">
                      <v-col cols="12">
                        <v-text-field
                          @keyup.enter="login"
                          v-model="user.email"
                          :rules="emailRules"
                          label="Email Adresi"
                          prepend-inner-icon="fa fa-envelope"
                          type="email"
                        ></v-text-field>
                      </v-col>
                    </v-row>
                    <v-row class="ma-1">
                      <v-col cols="12">
                        <v-text-field
                          @keyup.enter="login"
                          v-model="user.password"
                          :rules="passwordRules"
                          placeholder="Şifre"
                          prepend-inner-icon="fa fa-key"
                          :append-icon="passwordAppendIcon"
                          :type="passwordTextFieldType"
                          @click:append="showPassword"
                        ></v-text-field>
                      </v-col>
                    </v-row>
                    <v-col cols="12" class="mt-5">
                      <v-btn block rounded color="#ff4f00" :disabled="!valid" @click="login">
                        <span dark color="white">GİRİŞ</span>
                        </v-btn>
                    </v-col>
                  </v-row>
                </v-form>
              </v-card-text>
              <v-card-actions>
                <v-col cols="12 mt-10" class="text-center">
                  <span class="caption">
                    © {{ new Date().getFullYear() }} - Jira
                    <br />Software
                  </span>
                </v-col>
              </v-card-actions>
            </v-card>
          </v-hover>
        </v-col>
      </v-row>
      </v-img>
    </v-row>
  </v-container>
</template>


<script>
import { mapState } from "vuex";
import { LOGIN } from "@/store/actions.type";
import entityUser from "@/entity/user";
const initialize = () => {
  return Object.assign({},entityUser);
}
export default {
  name: "Login",
  data() {
    return {
      valid: false,
      user: initialize(),
      userInfo : {},
      emailRules: [
        v => !!v || "E-mail zorunlu",
        v => /.+@.+\..+/.test(v) || "Geçerli bir mail adresi giriniz."
      ],
      passwordRules: [v => !!v || "Şifre zorunlu"],
      passwordAppendIcon: "fa fa-eye",
      passwordTextFieldType: "password"
    };
  },
  methods: {
    showPassword() {
      this.passwordTextFieldType =
        this.passwordTextFieldType === "password" ? "text" : "password";
      this.passwordAppendIcon =
        this.passwordTextFieldType === "password"
          ? "fa fa-eye"
          : "fa fa-eye-slash";
    },
    login() {
      if (this.valid) {
        var user = this.user;
        this.$store
          .dispatch(LOGIN, user)
          .then(() => {
            this.user = initialize();
            this.$router.push({ name: "home" });
          })
          .catch(err => {
            this.$swal("HATA", err.errorMessage, "error");
          });
      }
    }
  },
  computed: {
    ...mapState({
      errors: state => state.user.errors
    })
  }
};
</script>
