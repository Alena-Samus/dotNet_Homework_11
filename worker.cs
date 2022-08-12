using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless11
{
    class worker : employees
    {
        private double hours;
        private double tarif;
        //private double salary;

        /// <summary>
        /// Конструктор для создания работника
        /// </summary>
        /// <param name="nameWorker"></param>
        /// <param name="hours"></param>
        /// <param name="tarif"></param>

        public worker(string nameWorker, double hours, double tarif) : base(nameWorker)
        {
            this.tarif = tarif;
            this.hours = hours;
            this.salary = this.tarif * this.hours;
            
        }

        /// <summary>
        /// Метод для вывода информации о работнике
        /// </summary>
        public override void printEmployeeInfo()
        {
            Console.WriteLine($"{this.nameEmployee} Ставка:{this.tarif} Количество часов:{this.hours} Заработная плата:{this.salary}");
        }
    }
}
