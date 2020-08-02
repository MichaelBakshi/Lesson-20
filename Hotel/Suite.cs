using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite : Room
    {
        public Suite(int roomNumber, float price) : base(roomNumber, price)
        {
        }

        protected override void SetPrice()
        {
            price = base.price + 100;
        }

        protected override void SetFeatures()
        {
            features = "TV, minibar, jacuzzi, king-size bed";
        }
    }
}
