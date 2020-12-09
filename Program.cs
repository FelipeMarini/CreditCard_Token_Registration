using System;
using Card_Registration.Classes;

namespace Card_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard m = new Mastercard();

            m.Number = "123456";   // SET number from Card.cs class

            Console.WriteLine(m.Number);   // GET number from Card.cs class

            m.CardName = "Felipe Marini";

            m.Flag = "Mastercard";

            Console.WriteLine($"Cardholder {m.CardName} - Token {m.Token}");
         
        }
    }
}
