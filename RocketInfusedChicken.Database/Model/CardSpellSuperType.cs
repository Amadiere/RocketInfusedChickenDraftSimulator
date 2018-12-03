using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class CardSpellSuperType
    {
        public int CardId { get; set; }
        public int SpellSuperTypeId { get; set; }

        public Card Card { get; set; }
        public SpellSuperType SpellSuperType { get; set; }
    }
}
