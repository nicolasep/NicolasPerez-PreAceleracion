using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Post.Practica.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Posts> Posts { get; set; }
        public ICollection<Comments> Comments { get; set; }

    }
}
