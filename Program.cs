using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<department> newListDepartment = new List<department>();

            newListDepartment.Add(new department("Предприятие"));

            newListDepartment[0].addUnder(" Ведомство_1");

            newListDepartment[0].dependence[0].addUnder("  Департамент_11");
            newListDepartment[0].dependence[0].addUnder("  Департамент_12");
            newListDepartment[0].dependence[0].addUnder("  Департамент_13");
            newListDepartment[0].dependence[0].dependence[1].addUnder("  Департамент_121");
            newListDepartment[0].dependence[0].dependence[1].addUnder("  Департамент_122");


            newListDepartment[0].addUnder(" Ведомство_2");
            newListDepartment[0].dependence[1].addUnder("   Департамент_21");

            newListDepartment[0].addUnder(" Ведомство_3");
            newListDepartment[0].dependence[2].addUnder("  Департамент_31");
            newListDepartment[0].dependence[2].addUnder("  Департамент_32");
            newListDepartment[0].dependence[2].dependence[0].addUnder("  Департамент_331");

            

            newListDepartment[0].dependence[0].dependence[1].employees.Add(new intern("   Интерн_1"));
            newListDepartment[0].dependence[0].dependence[0].employees.Add(new intern("   Интерн_1"));
            newListDepartment[0].dependence[0].dependence[0].employees.Add(new intern("   Интерн_2"));


            newListDepartment[0].dependence[0].employees.Add(new worker("   Сотрудник_1", 10, 25));

            newListDepartment[0].dependence[2].employees.Add(new worker("   Сотрудник_1", 40, 25));
            newListDepartment[0].dependence[2].employees.Add(new worker("   Сотрудник_2", 40, 125));
            newListDepartment[0].dependence[2].employees.Add(new worker("   Сотрудник_3", 40, 45));

            newListDepartment[0].dependence[0].addManager();
            newListDepartment[0].addManager();




            ////Console.WriteLine(newListDepartment.Count);

            foreach (department e in newListDepartment)
            {
                e.print();
            }


            //worker newWorker = new worker("Сотрудник_1", 10, 25);
            //newWorker.printEmployeeInfo();

            ;
            Console.ReadKey();
        }



    }
}
