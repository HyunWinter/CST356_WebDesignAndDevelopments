var m_student1 = '"id": "student1", "email": "student2@oit.edu"'
var m_student2 = '"id": "student2", "email": "student2@oit.edu"'
var m_student3 = '"id": "student3", "email": "student3@oit.edu"'
var m_student4 = '"id": "student4", "email": "student4@oit.edu"'
var m_students = '{"students": [{' 
    + m_student1 + '}, {'
    + m_student2 + '}, {'
    + m_student3 + '}, {'
    + m_student4 + '}]}'

function getStudents() {
    return JSON.parse(m_students);
}

function displayStudents(students) {

    var tableRows = "";

    for (i = 0; i < students.length; i++) {
        var id = students[i].id;
        var email = students[i].email;
        tableRows += "<tr><td>" + id + "</td><td>" + email + "</td></tr>";
    }

    document.getElementById("student-list").innerHTML = tableRows ;
}

function initializeStudents() {
    var data = getStudents();

    displayStudents(data.students);
}