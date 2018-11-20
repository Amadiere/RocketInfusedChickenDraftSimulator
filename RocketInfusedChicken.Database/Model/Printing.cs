using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class Printing
    {
        public int CardId { get; set; }
        public int SetId { get; set; }

        public virtual Card Card { get; set; }
        public virtual Set Set { get; set; }
    }
}
