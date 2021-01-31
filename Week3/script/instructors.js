var m_instructor1 = '"fname": "Professor", "mname": "x", "lname": "1"'
var m_instructor2 = '"fname": "Professor", "mname": "y", "lname": "2"'
var m_instructors = '{"instructors": [{' 
    + m_instructor1 + '}, {' 
    + m_instructor2 + '}]}'

function getInstructors() {
    return JSON.parse(m_instructors);
}

function displayInstructors(instructors) {

    var tableRows = "";

    for (i = 0; i < instructors.length; i++) {
        var fname = instructors[i].fname;
        var mname = instructors[i].mname;
        var lname = instructors[i].lname;
        tableRows += "<tr><td>" + fname + "</td><td>" + mname + "</td><td>" + lname + "</td></tr>";
    }

    document.getElementById("instructor-list").innerHTML = tableRows ;
}

function initializeInstructors() {
    var data = getInstructors();

    displayInstructors(data.instructors);
}