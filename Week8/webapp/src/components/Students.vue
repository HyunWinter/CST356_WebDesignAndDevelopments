<template>
  <!-- Leftside Contents START -->
  <div class="content">
    <h2 class="table_heading">Student Page</h2>
    <table class="table">
      <thead>
        <tr>
          <th>Student ID</th>
          <th>Email Address</th>
        </tr>
      </thead>
      <tbody id="student-list">
        <tr v-for="student in students" v-bind:key="student.student_id">
          <td>{{ student.student_id }}</td>
          <td>{{ student.email_address }}</td>
        </tr>
      </tbody>
    </table>
  </div>
  <!-- Leftside Contents END -->
</template>

<script>
import Vue from 'vue';

export default {
    name: "Students",
    methods: {
        getStudents: function() {
            let url = `http://${this.apiServer}/student`;

            Vue.axios.get(url).then(
                (response) => {
                    this.students = response.data;
                },
                (error) => {
                    console.log(error)
                }
            );
        }
    },
    mounted() {
        this.getStudents();
    },
    data() {
        return {
            students: [],
            apiServer: process.env.VUE_APP_API_SERVER,
        };
    },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
/* Table Style */
.table {
  border-collapse: collapse;
  font-size: 16px;
  width: 100%;
  /* 
    border-radius: 5px 5px 0 0;
    overflow: hidden; 
    */
  box-shadow: 0 0 20px rgba(0, 0, 0, 0.2);
}

.table thead tr {
  background-color: #424242;
  color: #ffffff;
  text-align: left;
  font-weight: bold;
}

.table th,
.table td {
  padding: 12px 15px;
}

.table tbody tr {
  border-bottom: 1px solid #dddddd;
}

.table tbody tr:nth-of-type(even) {
  background-color: #f3f3f3;
}

.table tbody tr:last-of-type {
  border-bottom: 2px solid #424242;
}

.table_heading {
  font-size: 25px;
  color: #424242;
}
</style>
