<template>
  <div id="app">
    <NavBar />
    <router-view />
  </div>
</template>

<script>
import NavBar from "./components/NavBar.vue";

export default {
  name: "App",
  components: {
    NavBar,
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  /* text-align: center;
    color: #2c3e50;
    margin-top: 60px; */
}
body {
  font-family: "Product Sans", sans-serif;
  margin: 0;
}
/* Leftside Contents */
.content {
  /* margin-left: 160px; */
  padding: 0 10px;
}
.content h2 {
  padding: 3px;
}
.content p {
  font-size: 16px;
}
#home_heading {
  padding: 3px;
  font-size: 25px;
  color: #424242;
}
/* Image with Source Text */
.image_source {
  list-style: none;
  padding: 0;
  font-size: small;
}

.image {
  height: auto;
  width: 100%;
}
</style>
