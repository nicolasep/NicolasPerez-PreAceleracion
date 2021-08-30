using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Post.Practica.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}
