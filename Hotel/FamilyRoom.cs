using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber, float price) : base(roomNumber, price)
        {
           
        }

        protected override void SetPrice()
        {
            price=base.price+150;
        }

        protected override void SetFeatures()
        {
            features = ", TV, minibar, 3 more beds for toddlers";
        }
    }
}
