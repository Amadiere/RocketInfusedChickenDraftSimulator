using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class Color
    {
        public int Id { get; set; }

        [MaxLength(1)]
        public string ShortCode { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public List<CardColor> CardColors { get; set; }
    }
}
