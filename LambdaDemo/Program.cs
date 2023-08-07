namespace LambdaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Demo Program");

            List<Person> listOfPerson = new List<Person>()
            {
                new Person() { SSN = 1, Name = "Sindhu", Address = "Banglore", Age = 23 },
                new Person() { SSN = 2, Name = "Harish", Address = "Mumbai", Age = 65 },
                new Person() { SSN = 3, Name = "Kalpesh", Address = "Delhi", Age = 32 },
                new Person() { SSN = 4, Name = "Arya", Address = "Hyderabad", Age = 18 },
                new Person() { SSN = 5, Name = "Kavitha", Address = "Pune", Age = 15 },
                new Person() { SSN = 6, Name = "Karthik", Address = "Maharashtra", Age = 70 },
            };
            DisplayPersonData(listOfPerson);
            PersonDataManagement.RemovePersonData(listOfPerson,"Harish");
            PersonDataManagement.RemovePersonData(listOfPerson, "ABC");

        }

        public static void DisplayPersonData(List<Person> list)
        {
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}