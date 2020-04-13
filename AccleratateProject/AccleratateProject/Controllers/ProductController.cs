using AccleratateProject.Models;
using AccleratateProject.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccleratateProject.Controllers
{
    public class ProductController : ApiController
    {
        private ProductDataRepository productRepository;

        public ProductController()
        {
            this.productRepository = new ProductDataRepository();
        }
        public ProductModel Get()
        {
            return productRepository.GetAllProducts();
       
    }
    }
}

