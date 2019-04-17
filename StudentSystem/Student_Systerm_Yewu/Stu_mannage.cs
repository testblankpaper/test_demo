using System;
using System.Collections.Generic;
using System.IO;
using StudentSystermRepotstory;
using Newtonsoft.Json;

namespace StudentSystermYewu
{
    public class Stu_mannage
    {
        private List<Student> s_student;

        public Stu_mannage()
        {
            List<Student> s_student = new List<Student>();
        }

        public List<Student> Get()
        {
            return s_student;
        }

        public void Search(List<Student> s_student)
        {
            if (s_student == null)
            {
                Console.WriteLine("学生信息为空，请先进行添加操作！");
                return;
            }
            Console.WriteLine("请输入查询方式：按名字查询请按1；按学号查询请按2");
            int case_tmp = int.Parse(Console.ReadLine());
            switch (case_tmp)
            {
                case 1:
                    {
                        Console.WriteLine("请输如学生名字：");
                        String name = Console.ReadLine();
                        Student tem = Search_Name(name);
                        if (tem == null)
                            break;
                        this.Display(tem);
                        break;
                    }
                case 2:
                    {
                        try { Console.WriteLine("请输如学号："); }
                        catch (Exception) { Console.WriteLine("输入错误，请重新输入！"); }
                        int number = int.Parse(Console.ReadLine());
                        Student tem = Search_Num(number);
                        if (tem == null)
                            break;
                        this.Display(tem);
                        break;
                    }
            }

        }
        public Student Search_Num(int student_num)
        {
            Student stu = new Student();
            foreach (Student temp in s_student)
            {
                if (temp.Num == student_num)
                {
                    stu = temp;
                    return stu;
                }
            }
            Console.WriteLine("库中没有此学生！");
            return null;
        }
        public Student Search_Name(string student_name)
        {
            Student stu = new Student();
            foreach (Student temp in s_student)
            {
                if (temp.Name == student_name)
                {
                    stu = temp;
                    return stu;
                }

            }
            Console.WriteLine("库中没有此学生！");
            return null;
        }

        public void Add()
        {
            try
            {
                Console.WriteLine("请输入学生名字：");
                string s = Console.ReadLine();
                Console.WriteLine("请输入学生学号：");
                int temp = int.Parse(Console.ReadLine());
                Student student = new Student(s, temp);
                Console.WriteLine("请添加课程，退出添加个人成绩请按0");
                int flag = 0;
                do
                {
                    Console.WriteLine("请输入课程名字：");
                    string grade_name = Console.ReadLine();
                    Console.WriteLine("请输入成绩：");
                    int grade = int.Parse(Console.ReadLine());
                    student.S_score.Add(new Score(grade_name, grade));
                    Console.WriteLine("请添加课程，退出添加个人成绩请按0");
                    flag = int.Parse(Console.ReadLine());
                } while (flag != 0);
                if (s_student == null)         //文件为空时，即当前s_student为null，此时不能调用方法
                {
                    this.s_student = new List<Student>();
                }
                s_student.Add(student);
            }
            catch (Exception)
            {
                Console.WriteLine("输入有误，请重新输入！");
            }

        }
        public void S_ort(List<Student> s_student)
        {
            if (s_student == null)
            {
                Console.WriteLine("学生信息为空，请先进行添加操作！");
                return;
            }
            Console.WriteLine("请输入排序科目");
            string temp = Console.ReadLine();
            foreach (Student tem in s_student)
            {
                tem.Flag(temp);
            }
            s_student.Sort((Student x, Student y) => -x.Flag_num1.CompareTo(y.Flag_num1));
            foreach (Student tem in s_student)
            {
                Console.WriteLine("姓名:" + tem.Name + "   " + "学号:" + tem.Num + "   " + temp + ":" + tem.Flag_num1);
            }
        }
        public void Tranverse(List<Student> s_student)
        {
            if (s_student == null)
            {
                Console.WriteLine("学生信息为空，请先进行添加操作！");
                return;
            }
            foreach (Student tem in s_student)
            {
                this.Display(tem);
            }
        }
        public void Delete(List<Student> s_student)
        {
            Console.WriteLine("请输入要删除学生的学号！");
            int s_num = int.Parse(Console.ReadLine());
            s_student.Remove(Search_Num(s_num));
            Console.WriteLine("删除成功！");

        }

        public void LoadFromFile()
        {
            var strData = File.ReadAllText("D:/我的C#/StudentSystem/student.txt");
            this.s_student = JsonConvert.DeserializeObject<List<Student>>(strData);
        }
        public void SaveToFile()
        {
            var strData = JsonConvert.SerializeObject(this.s_student);
            File.WriteAllText("D:/我的C#/StudentSystem/student.txt", strData);
        }

        public void Display(Student student)
        {
            Console.WriteLine("姓名：" + student.Name + "    " + "学号:" + student.Num);
            foreach (Score grade in student.S_score)
            {
                Console.WriteLine(grade.Score_name + ":" + grade.S_core);
            }
        }

        //public void ListEmpty(List<Student> s_student)
        //{
        //    if (s_student == null)
        //    {
        //        Console.WriteLine("学生信息为空，请先进行添加操作！");
        //        return;
        //    }
        //}

    }
}
