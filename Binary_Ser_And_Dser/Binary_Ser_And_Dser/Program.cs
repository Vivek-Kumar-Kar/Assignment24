using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace Binary_Ser_And_Dser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 15,
                FirstName = "Vivek",
                LastName = "Kar",
                Salary = 90000.00
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\Lenovo\\Desktop\\C# assignments\\Assignment24\\Binary_Ser_And_Dser\\employee.bin", FileMode.Create))
            {
                formatter.Serialize(fs, employee);
                Console.WriteLine("Created and Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            using (FileStream fs = new FileStream("C:\\Users\\Lenovo\\Desktop\\C# assignments\\Assignment24\\Binary_Ser_And_Dser\\employee.bin", FileMode.Open))
            {
                Employee deserialize = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("De-Serialized");
                Console.WriteLine(deserialize.Id);
                Console.WriteLine(deserialize.FirstName);
                Console.WriteLine(deserialize.LastName);
                Console.WriteLine(deserialize.Salary);

            }
            Console.ReadKey();


        }
    }
}