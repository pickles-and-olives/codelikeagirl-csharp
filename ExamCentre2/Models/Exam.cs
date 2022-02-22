namespace ExamCentre2.Models
{
    public class Exam 
    {
        public string? Subject { get; set; }
        public int Score { get; set; }
        public List<Student> Students { get; set; } 
        public List<Exam> Scores { get; set; }
        public List<Exam> CanditdateNumbers { get; set; }

        public Exam(string subject)
        {
            Subject = subject;
            Students = new List<Student>{};
            Scores = new List<Exam>{};
            CanditdateNumbers = new List<Exam>{};
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddScore(Exam score)
        {
            Scores.Add(score);
        }
        public void MarkPaper(Exam candidateNumber, Exam score)
        {
            candidateNumber.AddScore(score);
        }
}

}
