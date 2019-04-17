namespace StudentSystermRepotstory
{
    public class Score
    {
        string score_name;
        int score;

        public Score(string grade_name, int score_num)
        {
            this.score_name = grade_name;
            this.score = score_num;
        }
        public int S_core
        {
            get => score;
            set => score = value;
        }
        public string Score_name
        {
            get => score_name;
            set => score_name = value;
        }
    }
}
