using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class RoomService
    {
        internal void CleanRoom(RoomForTwo roomForTwo)
        {           
            roomForTwo.SetClean(true);
            Console.WriteLine(roomForTwo.GetFeatures()+" were cleaned");
        }

        internal void CleanRoom(FamilyRoom familyRoom)
        {
            familyRoom.SetClean(true);
            Console.WriteLine(familyRoom.GetFeatures() + " were cleaned");
        }

        internal void CleanRoom(Suite suite)
        {
            suite.SetClean(true);
            Console.WriteLine(suite.GetFeatures() + " were cleaned");
        }
    }
}
