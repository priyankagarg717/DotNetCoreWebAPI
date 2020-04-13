using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AccleratateProject.Models
{
    // Models used as parameters to AccountController actions.

    public class ProductModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        
    }
 
}
