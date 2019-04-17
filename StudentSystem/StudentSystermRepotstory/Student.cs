using System.Collections.Generic;

namespace StudentSystermRepotstory
{
    public class Student
    {
        private string name;
        private int num;
        private List<Score> s_score = new List<Score>();
        private int Flag_num;

        public Student() { }
        public Student(string name, int n_um)
        {
            this.Name = name;
            this.num = n_um;
        }
        public int Num
        {
            get => num;
            set => num = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public List<Score> S_score
        {
            get
            {
                return s_score;
            }
            set { }
        }
        public int Flag_num1
        {
            get => Flag_num;
            set => Flag_num = value;
        }

        public int Flag(string _name)
        {
            Flag_num = 0;
            if (_name == "总分")
            {
                foreach (Score t in S_score)
                {
                    Flag_num1 += t.S_core;
                }
                return Flag_num1;
            }
            else
            {
                foreach (Score t in S_score)
                {
                    if (t.Score_name == _name)
                    {
                        Flag_num1 = t.S_core;
                    }
                }
                return Flag_num1;
            }
        }
    }
}
