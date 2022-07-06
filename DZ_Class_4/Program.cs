using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Market a = new Market();
            Console.WriteLine(a);
            a.marketName = "Святзарск";
            a.specializationMarket = "Садоводческий магазин";
            a.Adres = "Слоновий юл 36";
            a.emailM = "sv9tsv9t@zors.mail.ru";
            a.phoneNumber = "+7-924-236-2378";
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}
