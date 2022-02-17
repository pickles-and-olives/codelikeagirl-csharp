namespace ExamCentre.Models
{
    public class Exam
    {
        public string? Subject {get; set;}
        public int studentScore {get; set;}

        public Exam(string subject)
        {
            Subject = Subject;
            
        }

        public void addStudent(int studentID)
        {
            studentID = 0;
        }
        public void markPaper(int studentID, int studentScore)
        {
        
        }

    }
}