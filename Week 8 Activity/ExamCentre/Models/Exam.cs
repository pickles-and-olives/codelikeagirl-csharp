namespace ExamCentre.Models
{
    public class Exam
    {
    public string? Subject { get; set; }
    public Exam(string subject)
    {
        Subject = subject;
    }

    public class Score
    {
        public int StudentScore { get; set; }
        public int StudentID { get; set; }
    
    public Score(int studentID, int score)
    {
        StudentScore = score;
        StudentID = studentID;
    }
    // static void MarkPaper(int StudentID, int StudentScore)
    // {   
    //     var student = StudentID;
    //     student.AddScore(StudentScore);

    }
    }
    }




