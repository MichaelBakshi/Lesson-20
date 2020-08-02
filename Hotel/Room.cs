using System;
using Clients;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    abstract public class Room
    {
        protected int roomNumber;
        protected float price;
        protected Guest guest;
        protected bool isClean;
        protected string features;

        public Room(int roomNumber, float price)
        {
            this.roomNumber = roomNumber;
            this.price = price;
            SetPrice();
            SetFeatures();
        }
        internal void SetGuest(Guest guest)
        {
            this.guest = guest;
        }

        internal Guest GetGuest()
        {
            return guest;
        }

        protected virtual void SetPrice()
        {
            price = 200;
        }

        protected abstract void SetFeatures();
       

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetClean(bool isClean)
        {
            this.isClean = isClean;
        }
        public bool IsClean()
        {
            return this.isClean;
        }

        public string GetFeatures()
        {
            return features;
        }

        public override  string ToString()
        {
            return $"[Room Number]:{roomNumber}, [Price]:{price}, [Guest]:{guest}, [Room is clean]:{isClean}, [Features]:{features}";
        }
    }
}
