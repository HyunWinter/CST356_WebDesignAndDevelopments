<template>
  <!-- Leftside Contents START -->
  <div class="content">
    <h2 class="table_heading">Instructor Page</h2>
    <table class="table">
      <thead>
        <tr>
          <th>First Name</th>
          <th>Middle Initial</th>
          <th>Last Name</th>
        </tr>
      </thead>
      <tbody id="instructor-list">
        <tr v-for="instructor in instructors" v-bind:key="instructor">
          <td>{{ instructor.fname }}</td>
          <td>{{ instructor.mname }}</td>
          <td>{{ instructor.lname }}</td>
        </tr>
      </tbody>
    </table>
  </div>
  <!-- Leftside Contents END -->
</template>

<script>
export default {
  name: "Instructors",
  mounted() {
    this.instructors = getInstructors();
  },
  data() {
    return {
      instructors: [],
    };
  },
};

function getInstructors() {
  return JSON.parse(m_instructors);
}

var m_instructor1 = '{"fname": "Professor", "mname": "x", "lname": "1"}, ';
var m_instructor2 = '{"fname": "Professor", "mname": "y", "lname": "2"}';
var m_instructors =
  '[' +
  m_instructor1 +
  m_instructor2 +
  "]";
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
