using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class Set
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Block { get; set; }

        [MaxLength(5)]
        public string Code { get; set; }

        [MaxLength(15)]
        public string SetType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<Printing> Printings { get; set; }
    }
}
