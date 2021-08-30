using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Post.Practica.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }
    }
}
