using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class CardColor
    {
        public int CardId { get; set; }
        public int ColorId { get; set; }

        public Card Card { get; set; }
        public Color Color { get; set; }
    }
}
