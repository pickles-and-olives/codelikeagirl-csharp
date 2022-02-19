
using ExamCentre.Models;

var exam1 = new Exam("Literature");

var exam = new List<Exam>{exam1};


var student1 = new Student("Kate", 4523, 77);

var student2 = new Student("Bella", 4487);

var student3 = new Student(4120, 80);

var student4 = new Student(4500, 68);

var student = new List<Student>{student1, student2, student3};


var score = new List<Exam>{};

student.Add(student4);
student3.AddScore(58);

//exam.MarkPaper(4487, 91);


Console.WriteLine(student1.StudentID);
Console.WriteLine(student2.StudentID);
Console.WriteLine(student3.Score);
Console.WriteLine(student4.Score);






