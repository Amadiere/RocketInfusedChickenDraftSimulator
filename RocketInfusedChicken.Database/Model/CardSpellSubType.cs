using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class CardSpellSubType
    {
        public int CardId { get; set; }
        public int SpellSubTypeId { get; set; }

        public Card Card { get; set; }
        public SpellSubType SpellSubType { get; set; }
    }
}
