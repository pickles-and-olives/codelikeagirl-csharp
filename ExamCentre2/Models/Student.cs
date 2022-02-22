namespace ExamCentre2.Models
{
    public class Student
    {
        private string? _Name { get; set; }
        public int CandidateNumber { get; set; }
        public int Score { get; set; }
        public List<Student> Scores { get; set; }

        public Student(int candidateNumber, int score)
        {
            CandidateNumber = candidateNumber;
            Scores = new List<Student>{};
        }
        public Student(string _name, int candidateNumber)
        {
            _Name = _name;
            CandidateNumber = candidateNumber;
        }

    }

}
