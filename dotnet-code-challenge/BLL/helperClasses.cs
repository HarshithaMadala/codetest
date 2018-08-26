using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Models;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Xml.Linq;
namespace dotnet_code_challenge.BLL
{
   public class HelperClasses
    {
        public  dynamic ConvertJson()
        {
            
                string jsonData = File.ReadAllText(@"C:\Users\phani\Desktop\Tests\code-challenge\dotnet-code-challenge\FeedData\Wolferhampton_Race1.json");
                Rootobject jsonObj = JsonConvert.DeserializeObject<Rootobject>(jsonData);

                Market[] jsonMar = jsonObj.RawData.Markets;
                Selection[] jsonSel = jsonMar.SelectMany(i => i.Selections).ToArray();

                var HorsePrices = from itemSel in jsonSel
                                  orderby itemSel.Price
                                  select new { HorsePrice = itemSel.Price, HorseName = itemSel.Tags.name };
            
                return HorsePrices;

        }

       
        public dynamic ConvertXml()
        {
            var xmlHorseDoc = XDocument.Load(@"C:\Users\phani\Desktop\Tests\code-challenge\dotnet-code-challenge\FeedData\Caulfield_Race1.xml");
            var xmlHorseDocNodes = from nodes in xmlHorseDoc.Descendants("race") select nodes;
            var xmlRaceHorseDocs=from nodes in xmlHorseDocNodes.Descendants("horse") select nodes;
            int i,k;
            float j;
         
           var xmlHorseName = xmlHorseDocNodes.Elements("horses").Elements("horse").ToArray();
          var  horsename = from node in xmlHorseName
                            let name = node.Attribute("name")
                            let number = node.Element("number")
                            select new { Name = (name != null) ? name.Value : "", Number = (number != null && Int32.TryParse(number.Value, out i)) ? i : 0 };
            var xmlHorsePrice = xmlHorseDocNodes.Elements("prices").Elements("price").Descendants("horse").ToArray();
            var horseprice = from node in xmlHorsePrice
                             let price = node.Attribute("Price")
                            let number = node.Attribute("number")
                            select new { Price = (price != null && float.TryParse(price.Value, out j)) ? j : 0, Number = (number != null && Int32.TryParse(number.Value, out k)) ? k : 0 };

           var horsenameprice= from n in horsename
                               from p in horseprice
                               where (n.Number== p.Number) 
                               orderby p.Price
                               select new {HorseName=n.Name,HorsePrice=p.Price};

            return horsenameprice;
        }
    }
}
