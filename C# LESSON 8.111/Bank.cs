using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_7
{
    public class Bank
    {


        public Client[] clients { get; set; }   

        public void showCardBalance(BankCard b)
        {
            Console.WriteLine(b.Balans);
        }

    }
}
