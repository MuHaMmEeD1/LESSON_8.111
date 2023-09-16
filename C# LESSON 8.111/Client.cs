using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_7
{
    public class Client
    {

        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public BankCard bankCard { get; set; }

        public Client() { }
        public Client(string id, string name, string surname, int age, int salary, BankCard bankCard)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
            this.bankCard = bankCard;
        }

        public void show()
        {

            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
            bankCard.show(); 


        }

    }
}
