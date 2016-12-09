using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReadWrite
{
    public class StudentProp
    {
        public int Rollno
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public String Cls
        {
            get; set;
        }
        public String Sem
        {
            get; set;
        }
        public SubProp Subjects
        {
            get; set;
        }
    }
    public class SubProp
    {
        public int Adbms
        {
            get; set;
        }
        public int Ns
        {
            get; set;
        }
        public int An
        {
            get; set;
        }
        public int Se
        {
            get; set;
        }
        public int Mc
        {
            get; set;
        }
        public double Percentage
        {
            get; set;
        }
        public int Total
        {
            get; set;
        }
    }
}
