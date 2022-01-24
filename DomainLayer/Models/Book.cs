using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public string AutorName { get; set; }
        public string Synopsis { get; set; }
    }
}
