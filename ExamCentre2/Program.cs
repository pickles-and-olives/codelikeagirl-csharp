using ExamCentre2.Models;

var exam1 = new Exam("Literature");
var exam2 = new Exam("Biology");

var student1 = new Student("Kate", 4599);
var student2 = new Student("Bella", 4678);
var student3 = new Student("Taylor", 4335);

exam1.AddStudent(student1);
exam1.AddStudent(student2);

exam2.AddStudent(student3);

exam1.MarkPaper(4599, 87);
exam1.MarkPaper(4678, 65);

exam2.MarkPaper(4335, 43);

Console.WriteLine(student1.Score);
Console.WriteLine(student2.Score);
Console.WriteLine(student3.Score);
