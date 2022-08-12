using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless11
{
    class department
    {

        private string nameDepartment { get; set; }
        public List<department> dependence;//Список подчиненных департаментов
        public List<employees> employees;//Список сотрудников

        /// <summary>
        /// Конструкторы 
        /// </summary>
        public department() 
        {
            this.dependence = new List<department>();
            this.employees = new List<employees>();
        }

        public department(string nameDepartment)
        {
            
            this.nameDepartment = nameDepartment;
            this.dependence = new List<department>();
            this.employees = new List<employees>();
        }

        /// <summary>
        /// Метод для добавления нового руководителя
        /// </summary>
        public void addManager()
        {
            manager newManager = new manager();
            double salary = 0;
            double minSalary = 1300;

            //Расчет заработной платы руководителя в зависимости от заработной платы работников
            foreach(employees e in this.employees)
            {
                salary += e.salary;
            }

            salary += newManager.countSalary(this.dependence,0);

            salary *= 0.15;

            if (salary < minSalary)
            {
               salary = minSalary;
            }

            this.employees.Insert(0,new manager("Руководитель ведомства", salary));//Добавляем руководителя в начало списка сотрудников
            
        }

        /// <summary>
        /// Метод для добавления подчиненного департамента
        /// </summary>
        /// <param name="nameUnderDepartment"></param>
        public void addUnder(string nameUnderDepartment)
        {
            this.dependence.Add(new department(nameUnderDepartment));
            //Console.WriteLine($"add done {nameUnderDepartment}");
        }




       //Метод для печати названия департамента
        private void printDepartment()
        {
            Console.WriteLine($"{this.nameDepartment}");
        }

        /// <summary>
        /// Метод для печати списка сотрудников
        /// </summary>
        /// <param name="currentListEmployee"></param>
        private void printEmployee(List<employees> currentListEmployee)
        {
            foreach(employees e in currentListEmployee)
            {
                if (e.GetType() == typeof(worker))
                {
                    (e as worker).printEmployeeInfo();
                }
                else
                {
                    e.printEmployeeInfo();
                }
                
            }
        }

        /// <summary>
        /// Метод для печати списка департаментов
        /// </summary>
        /// <param name="currentList"></param>
        private void printList(List<department> currentList)
        {
         
            foreach (department e in currentList)
                {
                //Console.WriteLine($" {e.nameDepartment}");
                e.printDepartment();
                printEmployee(e.employees);

                printList(e.dependence);
                    
                }


        }

        /// <summary>
        /// Печать структуры организации
        /// </summary>
        /// 
        public void print()
        {
            printDepartment();
            printEmployee(this.employees);
            printList(this.dependence);
        }
    }
}
