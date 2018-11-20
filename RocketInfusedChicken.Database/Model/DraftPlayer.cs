using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database.Model
{
    public class DraftPlayer
    {
        public int Id { get; set; }
        public int DraftId { get; set; }
        public int PlayerId { get; set; }
    }
}
