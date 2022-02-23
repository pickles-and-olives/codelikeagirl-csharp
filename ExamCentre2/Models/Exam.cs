namespace ExamCentre2.Models
{
    public class Exam 
    {
        public string? Subject { get; set; }
        public List<Student> Students { get; set; } 

        public Exam(string subject)
        {
            Subject = subject;
            Students = new List<Student>{};
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void MarkPaper(int candidateNumber, int score)
        {
            var student = Students.Find(x => x.CandidateNumber == candidateNumber);
            student?.AddScore(score);
        }
}

}
