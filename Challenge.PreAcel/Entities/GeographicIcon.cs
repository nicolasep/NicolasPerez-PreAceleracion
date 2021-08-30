﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.PreAcel.Entities
{
    public class GeographicIcon
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }
        public DateTime Created { get; set; }
        public int Height { get; set;}
        public string History { get; set; }
        public City City { get; set; }


    }
}
