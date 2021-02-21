<template>
  <div class="links">
    <span class="title" v-on:click="goToHome">Lab 5</span>
    <span v-on:click="goToHome">Home</span>
    <span v-on:click="goToStudents">Students</span>
    <span v-on:click="goToInstructors">Instructors</span>
  </div>
</template>

<script>
export default {
  name: "NavBar",
  methods: {
    goToHome: function () {
      this.$router.push({ path: "home" });
    },
    goToStudents: function () {
      this.$router.push({ path: "students" });
    },
    goToInstructors: function () {
      this.$router.push({ path: "instructors" });
    },
  },
};
</script>

<style scoped>
span {
  font-family: monospace;
  font-size: 18pt;
  cursor: pointer;
  padding: 6px 6px 6px 16px;
  color: #FFFFFF;
  text-align: center;
  text-decoration: none;
  color: #ffffff;
}

.title {
  font-weight: bold;
  padding-left: 6px;
  padding-right: 26px;
}

.links {
  background-color: #424242;
  padding: 10px;
}
</style>