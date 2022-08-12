using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless11
{
    class manager : employees
    {
        public manager()
        {

        }
        public manager(string namagerName, double salary) : base (namagerName,salary)
        {           
        }


        /// <summary>
        /// Метод для расчета заработной платы руководителя
        /// расчитывается рекурсивно
        /// </summary>
        /// <param name="currentDepartment">текущее ведомство, включая подчиненные</param>
        /// <param name="currentSalary">начальное значение заработной платы</param>
        /// <returns></returns>
        public double countSalary(List<department> currentDepartment, double currentSalary)
        {
            
            foreach(department e in currentDepartment)
            {
                foreach(employees f in e.employees)
                {
                    currentSalary += f.salary;
                }

                
                countSalary(e.dependence, currentSalary);
            }
                                    
            return currentSalary;
        }
    }
}
