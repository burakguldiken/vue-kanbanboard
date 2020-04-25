
<template>
  <div class="container-login100">
    <v-row justify="center" align="center">
      <v-col cols="6">
        <v-card>
          <v-card-text justify="center" align="center">
            <v-row  justify="center" align="center">
              <v-col cols="6">
                  <v-row justify="center" align="center">
                    <v-col cols="12">
                      <v-avatar class="avatar" color="grey" size="150">
                        <v-icon size="50" dark>fa fa-users</v-icon>
                      </v-avatar>
                    </v-col>
                  </v-row>
                  <v-form v-model="valid" @submit="login">
                  <v-row justify="center" align="center">
                    <v-col cols="10">
                      <v-text-field 
                        label="Email"  
                        filled rounded dense
                        @keyup.enter="login"
                        v-model="user.email"
                        :rules="emailRules"
                        prepend-inner-icon="fa fa-envelope"
                        type="email"
                      ></v-text-field>
                      <v-text-field
                        label="Password"  
                        filled rounded dense
                        @keyup.enter="login"
                        v-model="user.password"
                        :rules="passwordRules"
                        prepend-inner-icon="fa fa-lock"
                        :append-icon="passwordAppendIcon"
                        :type="passwordTextFieldType"
                        @click:append="showPassword"
                      ></v-text-field>
                      <v-btn 
                        rounded 
                        color="green" 
                        dark
                        block
                        large
                        @click="login"
                        ><span>LOGIN</span></v-btn>
                    </v-col>
                    <v-col cols="10">
                      <span class="font-weight-bold">Forgot Email/Password?</span>
                    </v-col>
                    <v-col cols="10">
                      <span class="font-weight-bold"><v-icon class="mr-2" small>fa fa-arrow-right</v-icon>Create Account</span>
                    </v-col>
                  </v-row>
                  </v-form>     
              </v-col>
              <v-col cols="6">
                <v-row justify="center" align="center">
                  <v-icon size="300" color="green">fab fa-vuejs</v-icon>
                </v-row>
              </v-col>
            </v-row>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </div>
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
</script>-->

<style scoped>
.container-login100 {
  width: 100%;
  min-height: 100vh;
  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-items: center;
  padding: 15px;
  background: #9053c7;
  background: -webkit-linear-gradient(-135deg, #c850c0, #4158d0);
  background: -o-linear-gradient(-135deg, #c850c0, #4158d0);
  background: -moz-linear-gradient(-135deg, #c850c0, #4158d0);
  background: linear-gradient(-135deg, #c850c0, #4158d0);
}
</style>

