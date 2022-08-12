using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless11
{
    class employees
    {/// <summary>
     /// Список полей типа работники
     /// </summary>
        public string nameEmployee;
        public double salary { get; set; }

      
        /// <summary>
        /// Метод для получения имени сотрудника
        /// </summary>
        /// <returns></returns>
        public string NameEmployee()
        {
            return this.nameEmployee;
        }
        /// <summary>
        /// Конструктор для создания нового работника
        /// </summary>
        /// <param name="nameEmployee">Имя работника</param>
        /// <param name="salary">Заработная плата</param>
        
        public employees()
        {

        }
        public employees(string nameEmployee, double salary)
        {
            this.nameEmployee = nameEmployee;
            this.salary = salary;
        }
        public employees(string nameEmployee)
        {
            this.nameEmployee = nameEmployee;
            
        }


        /// <summary>
        /// Метод для вывода информации о работнике
        /// </summary>
        public virtual void printEmployeeInfo()
        {
            Console.WriteLine($"{this.nameEmployee} Заработная плата: {this.salary} ");
        }
    }
}
