namespace ExamCentre.Models
{
    public class Student
    {
        private string? _name {get; set;}
        public int StudentID {get; set;}
        public int Score {get; set;}

        public Student(string name, int studentID)
        {
            _name = name;
            StudentID = studentID;
        }

        public void studentScore(int studentID, int score)
        {
            StudentID = studentID;
            Score = score;
        }
}
}