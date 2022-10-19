using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.IO;
namespace DAL
{
    public class personDAL
    {
        public personBO read()
        {
            FileStream fout = new FileStream("data.txt",FileMode.Open);
            StreamReader sre = new StreamReader(fout);

            String line = sre.ReadLine();
            string[] data = line.Split(',');

            personBO person = new personBO();

            person.name = data[0];
            person.rollNo = data[1];
            person.degree = data[2];
            person.salary = float.Parse(data[3]);
            person.tax = float.Parse(data[4]);

            return person;
        }
        public void save(personBO bo)
        {
            FileStream fin = new FileStream("data.txt",FileMode.Create);
            StreamWriter stw = new StreamWriter(fin);

            stw.WriteLine(bo.name + "," + bo.rollNo + "," + bo.degree + "," + bo.salary + "," + bo.tax);

            stw.Close();
            fin.Close();

        }
    }
}
