using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
namespace CsvDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath=@"Worldcities.csv";
            using var streamReader = File.OpenText(fpath);
            using var csvReader = new CsvReader(streamReader);
            IEnumerable<Cities> users = csvReader.GetRecords<Cities>();
              

            
            // foreach(var item in users)
            // {
            //     Console.WriteLine(item);
            // }
             //var cityname=users.Select(s=>s.city).ToList();
            // foreach(var c in cityname)
            // {
            //     Console.WriteLine(c);
            // }

            //    var cityCount=users.GroupBy(x=>x.city);
            //     Console.WriteLine("Country wise city count:");
            //    foreach(var item1 in cityCount)
            //    {
            //         foreach(var i in item1)
            //         {
            //              Console.WriteLine(i.country+"\t"+item1.Count());
            //         }
                   
            //    }
            //  var stateCount=users.GroupBy(s=>s.admin_name);
            // Console.WriteLine("CountryWise State count:");
            // foreach(var i in stateCount)
            // {
            //     foreach(var item in i)
            //     {
            //         Console.WriteLine(item.admin_name+"\t"+i.Count());
            //     }
                
            // }  
            // }
          //   var Populated=users.Select(p=>p.population);
           
          
          // foreach (var item in Populated)
          //     {
          //       double d=Double.parseDouble(i); 
          //     } 

           
            //     var uniqueCapital=users.Select(c=>c.capital).Distinct().ToList();
            //    foreach(var c in uniqueCapital)
            //    {
            //         Console.WriteLine(c);
            //    }
            // var hasDuplicatedEntries =users
            //                        .GroupBy(d=>d.city)
            //                        .Any(e => e.Count() > 1);
            // if(hasDuplicatedEntries)
            // {
            //     foreach(var item in )

            // }
            // var totalDupeItems = users.GroupBy(x => x.city).Count(grp =>grp.Count() > 1);
            // Console.WriteLine("Duplicate Cities:");
            // Console.WriteLine(totalDupeItems);

            // var reSpace=String.Join("", "New York".Split(" "));
            // Console.WriteLine("Remove Space in New York:");
            // Console.WriteLine(reSpace);

            // var sameLat=users.GroupBy(l=>l.lat);
            // foreach(var item in sameLat)
            // {
            //     //Console.WriteLine(item.Key,item.Count());
            //     foreach(var slat in item)
            //     {
            //         Console.WriteLine(slat.lat +"\t"+ slat.city);
            //     }
            // }
            // var sameLng=users.GroupBy(l=>l.lng).Distinct();
            // foreach(var item in sameLng)
            // {
            //     //Console.WriteLine(item.Key,item.Count());
            //     foreach(var slng in item)
            //     {
            //         Console.WriteLine(slng.lng +"\t"+ slng.city);
            //     }
            // }
            // var orderPopulation=users.OrderBy(p=>p.population);
            // Console.WriteLine("Order Cities by Population:");
            // foreach(var op in orderPopulation)
            // {
            //     Console.WriteLine(op.city+"\t"+op.population);
            // }
            // var orderCity=users.OrderBy(c=>c.city);
            // Console.WriteLine("Order city in A to Z :");
            // foreach(var c in orderCity)
            // {
            //     Console.WriteLine(c.city);
            // }
            // var totalPopulation=users.Sum(t=>t.population);
            // Console.WriteLine("Total Population:{0}",totalPopulation);
            // var cityname=users.Select(s=>s.city).ToList();
            // Console.WriteLine("Enter a city:");
            // string myCity=Console.ReadLine();
            // if(cityname.Contains(myCity))
            // {
            //     Console.WriteLine("My City is:{0}",myCity);
            // }
            // else{
            //     Console.WriteLine("Not Found");
            // }
            var countryName=users.Select(c=>c.country);
             Console.WriteLine("Enter a country:");
            string myCountry=Console.ReadLine();
            var searchCapital = users.OrderBy(x => x.country).ThenBy(x => x.capital).Distinct();  

             foreach(var items in searchCapital)
             {
                
              Console.WriteLine("Counrty={0} Capital={1}",items.country,items.capital);
            }
             }
            
			         

            
               
}

                   
}



