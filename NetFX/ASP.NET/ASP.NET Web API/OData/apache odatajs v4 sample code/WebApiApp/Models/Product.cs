using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiApp.Models
{
    public class Product
    {
        [Key]
        public virtual Int32 Id { get; set; }

        public virtual String Name { get; set; }
    }
}