using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivresWebApplication.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public String Titre { get; set; }
        public int  AnneePub { get; set; }
        public String Auteur { get; set; }
    }
}
