using System;
using System.Linq;
using System.Collections.Generic;
using dotnet_code_challenge.BLL;


namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            HelperClasses helpercls = new HelperClasses();
            var  jsonhorsePrices= helpercls.ConvertJson();
            var xmlhorsePrices = helpercls.ConvertXml();
           
            foreach (var horse in jsonhorsePrices)
            {
                Console.WriteLine("JsonHorsePrice = {0} JsonHorseName = {1}", horse.HorsePrice, horse.HorseName);
            }
            foreach (var horse in xmlhorsePrices)
            {
                Console.WriteLine("xmlHorsePrice = {0} xmlHorseName = {1}", horse.HorsePrice, horse.HorseName);
            }
            Console.Read();
        }

    }
}





