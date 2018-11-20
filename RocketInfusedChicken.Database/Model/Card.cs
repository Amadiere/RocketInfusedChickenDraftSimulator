using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class Card
    {
        public int Id { get; set; }
        public int MultiverseId { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Printing> Printings { get; set; }
    }
}
