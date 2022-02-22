using ExamCentre2.Models;

var exam = new Exam("Literature");

var student1 = new Student("Kate", 4599);
var student2 = new Student("Bella", 4678);
var student3 = new Student("Taylor", 4335);


exam.AddStudent(student1);
exam.AddStudent(student2);

exam.MarkPaper(4599, 99);

Console.WriteLine(student1.Score);
Console.WriteLine(student2.Score);






