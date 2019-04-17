using System;
using StudentSystermYewu;
using System.Text;

namespace StudentSysterm
{
    class StudentSysterm
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Stu_mannage mannage = new Stu_mannage();
            mannage.LoadFromFile();
            Console.WriteLine("请选择操作");
            do
            {
                Console.WriteLine("1.添加  2.查询  3.排序  4.遍历  5.删除学生  0.退出并保存!");
                int case_tmp = int.Parse(Console.ReadLine());
                switch (case_tmp)
                {
                    case 1: mannage.Add(); break;
                    case 2: mannage.Search(mannage.Get()); break;
                    case 3: mannage.S_ort(mannage.Get()); break;
                    case 4: mannage.Tranverse(mannage.Get()); break;
                    case 5: mannage.Delete(mannage.Get()); break;
                    case 0:
                        {
                            mannage.SaveToFile();
                            return;
                        }
                    default: break;
                }
            } while (true);
        }
    }
}
