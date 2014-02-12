using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Data.Common;
using System.Data;
using System.Data.Objects;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string city = "London";
            //using (EinsteinEntities entities = new EinsteinEntities())
            //{
            //    ObjectQuery<CardInfo> query = entities.CreateQuery<CardInfo>(
            //    "SELECT *  FROM CardInfo WHERE CardID = @CardID",
            //    new ObjectParameter("CardID", city)
            //    );

            //    if (query != null)
            //    {
            //        foreach (CardInfo c in query)
            //            Console.WriteLine(c.CardID);
            //    }
            //}

//            string city = "London";
//using (EinsteinEntities entities = new EinsteinEntities())
//{
//var query = from c in entities.CardInfo
//where c.CardID == city
//select c;
 
//foreach (CardInfo c in query)
//Console.WriteLine(c.CardID);
//}

            string city = "London";
using (EinsteinEntities entities = new EinsteinEntities())
{
var query = entities.CardInfo.Where(c=>c.CardID == "sdfsdf");
 
foreach (CardInfo c in query)
 Console.WriteLine(c.CardID);
}
        }
    }
}
