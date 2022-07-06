using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class_4
{
    internal class Market
    {
        public string marketName { get; set; }
        public string Adres { get; set; }
        public string specializationMarket { get; set; }
        public string emailM { get; set; }
        public string phoneNumber { get; set; }
        public Market(string marketName = "Market", string adres = "dungeons1", string specializationMarket  = "souleater",
            string emailM = "12345@mail.ru", string phoneNumber="+7-923-777-96-75")
        {
            this.marketName = marketName;
            Adres = adres;
            this.specializationMarket = specializationMarket;
            this.emailM = emailM;
            this.phoneNumber = phoneNumber;
        }
       public override string ToString()
        { 
            string result ="Название магазина : "+ marketName + "\n" + "Адресс : " + Adres + 
                "\n"+"Профиль магазина : " + specializationMarket + "\n" + "Электронная почта : " + emailM + "\n" +"Номер телефона : "+ phoneNumber;
            return result;
        }
    }
}
