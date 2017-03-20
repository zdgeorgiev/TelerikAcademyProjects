const course = (function () {
    let title,
        presentations = [],
        students = [];

    function init(courseTitle, presentationsList) {

        validateCourseAndPresentations(courseTitle, presentationsList);

        title = courseTitle;
        presentations = presentationsList
            .map(p => {
                return {
                    title: p.title,
                    homework: p.homework || [],
                }
            });
    }

    function validateCourseAndPresentations(courseTitle, presentationsList) {
        validateTitle(courseTitle);

        if (presentationsList.length === 0)
            throw 'Presentations cannot be empty list';

        presentationsList.forEach(p => validateTitle(p.title));
    }

    function validateTitle(title) {

        if (typeof title !== 'string')
            throw 'Title must be a string';

        if (title.length < 1)
            throw 'Title must be atleast 1 character';

        if (title.match(/\s{2,}/g))
            throw 'Title cannot contains consecutive spaces';

        if (title[0] === ' ' || title[title.length - 1] === ' ')
            throw 'Title cannot start or end with whitespace';
    }

    function addStudent(firstAndLastName) {

        const student = parseStudent(firstAndLastName);

        students.push({
            ID: students.length + 1,
            firstName: student.firstName,
            secondName: student.secondName,
            submitedHomeworks: 0
        });
    }

    function parseStudent(firstAndLastName) {

        if (firstAndLastName.length < 3 || firstAndLastName.indexOf(' ') === -1)
            throw `${firstAndLastName} must be in format [<firstname> <secondname>]`;

        const firstName = firstAndLastName.split(' ')[0],
            secondName = firstAndLastName.split(' ')[1];

        if (secondName.match(/\s*/g))
            throw `${firstAndLastName} must contains only one space between fn and ln`;

        validateStudentName(firstName);
        validateStudentName(firstAndLastName);

        return {
            firstName: firstName,
            secondName: secondName
        }
    }

    function validateStudentName(name) {
        if (name.match(/^[A-Z][a-z]+&/g))
            throw 'Name must start with uppercase letter and all others must be lowercast'
    }

    function getAllStudents() {
        return students.map(s => {
            return {
                firstName: s.firstName,
                secondName: s.secondName,
                id: s.ID
            }
        });
    }

    function submitHomework(studentID, presentationID) {

        validateID(studentID, students);
        validateID(presentationID, presentations);

        students[studentID - 1].submitedHomeworks++;
    }

    function validateID(id, idCollection) {
        if (typeof id !== 'number' || id < 1)
            throw 'ID must be and non zero positive number';

        if (idCollection.some(i => i.ID === id))
            throw `${idCollection} doesnt contains id ${id}`;
    }

    function pushExamResults(results) {

        // Hashmap with ids
        let alreadyProcessed = {};

        results
            .forEach(r => {
                validateCurrentResult(r);

                if (alreadyProcessed.hasOwnProperty(r.StudentID))
                    throw `Student with id ${r.StudentID} already've been processed`;

                students[r.StudentID - 1].examPoints = r.score;
                alreadyProcessed[r.StudentID] = true;
            });
    }

    function validateCurrentResult(result) {

        const studentID = result.StudentID,
            studentScore = result.score;

        validateID(studentID, students);

        if (typeof studentScore !== 'number' || studentScore < 0)
            throw `Invalid score ${studentScore}`;
    }

    function getTopStudents() {

        let sorted = students.sort(
            (x, y) => x.examPoints * 0.75 + (x.submitedHomeworks * 0.25 / presentations.length) -
                (y.examPoints * 0.75 + (y.submitedHomeworks * 0.25 / presentations.length)))

        return sorted.slice(0, 10);
    }

    return {
        init: init,
        addStudent: addStudent,
        getAllStudents: getAllStudents,
        submitHomework: submitHomework,
        pushExamResults: pushExamResults,
        getTopStudents: getTopStudents
    }
})();

course.init('JS Fundamentals', [{ title: 'Variables' }, { title: 'Methods' }, { title: 'Functions' }]);