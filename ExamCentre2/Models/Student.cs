namespace ExamCentre2.Models
{
    public class Student
    {
        private string? _Name { get; set; }
        public int CandidateNumber { get; set; }
        public int Score { get; set; }
        public List<int> Scores { get; set; }
        public Student(string _name, int candidateNumber)
        {
            _Name = _name;
            CandidateNumber = candidateNumber;
            Scores = new List<int>{Score};
        }
        public void AddScore(int score)
        {
            Score = score;
            Scores.Add(score);
        }


    }

}
