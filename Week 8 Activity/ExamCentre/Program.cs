
using ExamCentre.Models;

var exam1 = new Exam("Literature");

var exam2 = new Exam("Anthopology");

var exam3 = new Exam("Computer Science");

var exam = new List<Exam>
{
    exam1, exam2, exam3
};


var student1 = new Student("Kate", 4523);

var student2 = new Student("Bella", 4487);

var student3 = new Student("Taylor", 4120);

var student = new List<Student>
{
    student1, student2, student3
};

// exam.addStudent(student1);
// exam.addStudent(student2);

// exam.markPaper(student1);

Console.WriteLine(student1.Score);
Console.WriteLine(student2.Score);
Console.WriteLine(student3.Score);





