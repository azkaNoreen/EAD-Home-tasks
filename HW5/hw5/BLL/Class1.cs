using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class personBLL
    {
        public personBO Read()
        {
            personDAL p = new personDAL();
            return p.read();
        }
        public void Save(personBO bo)
        {
            bo.tax=calTax(bo.salary);
            //write to file
            personDAL personD = new personDAL();
            personD.save(bo);
        }
        private float calTax(float sal)
        {
            float calTax = 0;
            if (sal > 50000)
            {
                calTax = 1000;
            }
            else{
                calTax = 0;
            }
            return calTax;
        }
    }
}
