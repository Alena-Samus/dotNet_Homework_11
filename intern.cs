using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless11
{
    class intern : employees
    {
        //public intern(string nameEmployee, int salary):
        //    base (nameEmployee, salary)
        //{
          
        //}
        /// <summary>
        /// Конструктор для создания нового интерна
        /// </summary>
        /// <param name="nameEmployee"></param>
        public intern(string nameIntern) : base(nameIntern, 500)
        {

        }
    }

}
