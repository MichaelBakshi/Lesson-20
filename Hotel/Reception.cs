using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public static class Reception
    {
        private const int numberOfRooms = 10;
        private static int numberOfGuests;
        private static  Room[] rooms = new Room[numberOfRooms   ];
        private static RoomService roomService = new RoomService();

        public static void CheckIn(Guest guest)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                //Room room = rooms[i];

                if (rooms[i].GetGuest() == null)
                {
                    rooms[i].SetGuest(guest);
                    numberOfGuests++;
                }   
            }
        }

        public static void CheckOut(Room room)
        {
            room.SetGuest(null);
            numberOfGuests--;
        }

        public static bool IsRoomFree(Room room)
        {
            if (room.GetGuest() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void SendRoomService(RoomForTwo room)
        {
            roomService.CleanRoom(room);  
        }

        private static void SendRoomService(FamilyRoom room)
        {
            roomService.CleanRoom(room);
        }

        public  static void SendRoomService(Suite room)
        {
            roomService.CleanRoom(room);

        }

    }
}
