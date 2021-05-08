using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk
{
    public class DeskQuote
    {
        Dictionary<string, List<int>> rushPrices = new Dictionary<string, List<int>>()
        {
            {"3", new List<int>(){60,70,80 } },
            {"5", new List<int>(){40,50,60 } },
            {"7", new List<int>(){30,35,40 } },
        };

        public int getRushPrice(string days, int size)
        {
            int index = size < 1000 ? 0 : size < 2000 ? 1 : 2;
            return rushPrices[days][index];
        }

        public enum Surface: int
        {
            oak = 200,
            laminate = 100,
            pine = 50,
            rosewood = 300,
            veneer = 125,
            None = 0
        }

        public int getSurfacePrice(Surface surface)
        {
            return (int) surface;
        }

        public int getSurfaceAreaPrice(int size)
        {
            return size > 1000 ? size : 0;
        }

        public int calculateQuote(int width, int depth, int numberOfDrawers, Surface surface, string days)
        {
            const int BASE_PRICE = 200;
            int priceAreaPrice = getSurfaceAreaPrice(width * depth);
            int priceDrawers = numberOfDrawers * 50;
            int priceMaterials = getSurfacePrice(surface);
            int priceRushOrder = getRushPrice(days, width * depth);
            return BASE_PRICE + priceAreaPrice + priceDrawers + priceMaterials + priceRushOrder;
        }
    };
}
