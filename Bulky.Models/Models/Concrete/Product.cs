using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Bulky.Models.Models.Abstract;

namespace Bulky.Models.Models.Concrete
{
    public class Product : Base
    {
        //bu keyi create ekranına koyup değer atayıp kayıt edersen uygulama patlar
        
       
        public string Title { get; set; }
        public string Description { get; set; }
       
        public string ISBN { get; set; }
       
        public string Author { get; set; }


        public double ListPrice { get; set; }

        
        public double Price { get; set; }

       
        public double Price50 { get; set; }

       
        public double Price100 { get; set; }

        public int CategoryId { get; set; }

       
        public Category Category { get; set; }
        // ForeignKey yapısı tanımladığın sayı dışında başka birşey kullanmana izin vermez
     
        public string ImageUrl { get; set; }
    }
}
