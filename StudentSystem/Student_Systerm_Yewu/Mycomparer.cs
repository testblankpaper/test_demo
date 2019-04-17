using System.Collections.Generic;
using StudentSystermRepotstory;


namespace StudentSystermYewu
{
    class Mycomparer : IComparer<Student>
    {
        int IComparer<Student>.Compare(Student x, Student y)
        {
            return (x.Flag_num1.CompareTo(y.Flag_num1));
            //throw new notimplementedexception();
        }
    }
}
