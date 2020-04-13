using AccleratateProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AccleratateProject.Services
{
    public class ProductDataRepository
    {

        //string jsonData = @"{'Name':'Truck','id': '1'}";
       
      //  string jsonData = @"{  'Name':'Jignesh',  'Id':'Trivedi'  }";  
  

       /* public ProductModel[] GetAllProducts()
        {
            return new ProductModel[]
            {
            new ProductModel
            {
                Id = 1,
                Name = "Glenn Block"
            },
            new ProductModel
            {
                Id = 2,
                Name = "Dan Roth"
            }
            };
        }*/
       
        public ProductModel GetAllProducts()
        {

          
            string jsonFilePath = "c:\\users\\hp\\documents\\visual studio 2015\\Projects\\AccleratateProject\\AccleratateProject\\json.json";

            string json = File.ReadAllText(jsonFilePath);
            ProductModel myDetail = JsonConvert.DeserializeObject<ProductModel>(json);

            return myDetail;
        }

    }
}