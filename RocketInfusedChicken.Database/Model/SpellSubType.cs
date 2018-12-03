using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class SpellSubType
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public List<CardSpellSubType> CardSubTypes { get; set; }
    }
}
