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

        [MaxLength(50)]
        public string ManaCost { get; set; }

        [MaxLength(25)]
        public string Layout { get; set; }

        public int ConvertedManaCost { get; set; }

        [MaxLength(255)]
        public string CardTypeText { get; set; }

        [MaxLength(15)]
        public string Rarity { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        public int Power { get; set; }
        public int Toughness { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }

        public List<CardSpellType> Types { get; set; }
        public List<CardSpellSuperType> SuperTypes { get; set; }
        public List<CardSpellSubType> SubTypes { get; set; }

        public List<CardColor> CardColors { get; set; }
        public List<Printing> Printings { get; set; }
    }
}
