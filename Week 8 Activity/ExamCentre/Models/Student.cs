namespace ExamCentre.Models
{   //Create a Student class to allow us to add students to the system.
    public class Student
    {
        //The student’s name. This is sensitive information that is not needed by the person entering grades into the system.
        private string? _name {get; set;}
        //A candidate number  to identify the student for markers and be available to all parts of the system
        public int StudentID {get; set;}
        //A score that the student is given (from 0-100) for the exam.
        public int Score {get; set;}

        public Student(string name, int studentID, int score)
        {
            _name = name;
            StudentID = studentID;
            Score = score;
        }

        public Student(string name, int studentID)
        {
            _name = name;
            StudentID = studentID;
        }

        public Student(int studentID, int score)
        {
            StudentID = studentID;
            Score = score;
        }
        public void AddScore(int score)
        {
            Score = score;
        }
    }
}
