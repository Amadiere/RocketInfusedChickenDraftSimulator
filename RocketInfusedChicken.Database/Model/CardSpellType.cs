using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class CardSpellType
    {
        public int CardId { get; set; }
        public int SpellTypeId { get; set; }

        public Card Card { get; set; }
        public SpellType SpellType { get; set; }
    }
}
