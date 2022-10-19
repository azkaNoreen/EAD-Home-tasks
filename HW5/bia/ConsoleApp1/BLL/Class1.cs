using System;
using BO;
using DAL;
namespace BLL
{public class PersonBLL
	{public PersonBO Read()

		{
			PersonDAL personDAL = new PersonDAL();

			return personDAL.read();

		}

		public void save(PersonBO personbo)
		{
			PersonDAL personDAL = new PersonDAL();

			personbo.tax = calTax(personbo.salary);

			personDAL.save(personbo);
		}
		private float calTax(float salary)
		{
			float tax = 0;
			if (salary > 50000)
			{
				tax = 1200;
			}
			return tax;
		}



	}
}
