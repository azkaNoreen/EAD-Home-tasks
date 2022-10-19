using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class personBO
    {
        public string name;
        public string rollNo;
        public string degree;
        public float salary;
        public float tax;

        public string Name { set; get; }
        public string RollNo { set; get; }
        public string Degree { set; get; }
        public float Salary { set; get; }
        public float Tax { set; get; }

        public personBO() { }
        public personBO(String n,string r, string d, float s)
        {
            this.name = n;
            this.rollNo = r;
            this.degree = d;
            this.salary = s;
        }
        public string show()
        {
            return this.name +  " your tax is " + this.tax +" on salary "+this.salary;
        }

    }
}
