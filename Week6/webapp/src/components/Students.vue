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
        <tr v-for="student in students" v-bind:key="student">
          <td>{{ student.id }}</td>
          <td>{{ student.email }}</td>
        </tr>
      </tbody>
    </table>
  </div>
  <!-- Leftside Contents END -->
</template>

<script>
export default {
  name: "Students",
  mounted() {
    this.students = getStudents();
  },
  data() {
    return {
      students: [],
    };
  },
};

function getStudents() {
  return JSON.parse(m_students);
}

var m_student1 = '{"id": "student1", "email": "student2@oit.edu"}, ';
var m_student2 = '{"id": "student2", "email": "student2@oit.edu"}, ';
var m_student3 = '{"id": "student3", "email": "student3@oit.edu"}, ';
var m_student4 = '{"id": "student4", "email": "student4@oit.edu"}';
var m_students =
  '[' +
  m_student1 +
  m_student2 +
  m_student3 +
  m_student4 +
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
