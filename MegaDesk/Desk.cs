using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk
{
    public class Desk : DeskQuote
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numberOfDrawers { get; set; }

        public Desk(int width, int depth, int numberOfDrawers)
        {
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers;
        }
    }
}