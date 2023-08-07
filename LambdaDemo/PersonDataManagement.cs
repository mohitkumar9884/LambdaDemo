using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    internal class PersonDataManagement
    {
        public static void RetreiveTop2RecordsBasedOnAge(List<Person> list)
        {
            //List<Person> sortedData = list.OrderBy(p => p.Age).ToList();
            //Console.WriteLine("\nSorted in ascending order based on Age");
           // Program.DisplayPersonData(sortedData);
           // List<Person> lessThan60=sortedData.Where(p => p.Age<60).ToList();
            //Console.WriteLine("\nLess than 60 Age records");
           // Program.DisplayPersonData(lessThan60);
           // List<Person> top2 = lessThan60.Take(2).ToList();
           // Console.WriteLine("\nTop2 records whos age less than 60");
           // Program.DisplayPersonData(top2);
            List<Person> top2Records = list.OrderBy(p=> p.Age).Where(p=>p.Age<60).Take(2).ToList();
            Console.WriteLine("\nRetreive Top2 Records Based On Age");
            Program.DisplayPersonData(top2Records);
        }

        public static void FindTeenageAgeRecords(List<Person> list)
        {
            List<Person>teenageRecords=list.Where(p=> (p.Age <= 18 &&  p.Age >=13)).ToList();
            Console.WriteLine("\nFind Teenage Age Records between 13 to 18");
            Program.DisplayPersonData(teenageRecords);

        }

        public static void FindAverageAge(List<Person> list)
        {
            double average = list.Average(p=> p.Age);
            Console.WriteLine("\nAverage age is :" + average);
        }

        public static void SearchForPersonBasedOnName(List<Person> list,string input)
        {
            List<Person>teenageRecords = list.Where(p => (p.Name == input)).ToList();
            if(teenageRecords.Count != 0)
            {
                Console.WriteLine("{0} is present in our records", input);
            }
            else
            {
                Console.WriteLine("{0} is not present in our records", input);
            }
        }
    }
}
