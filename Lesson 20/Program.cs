using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Suite s = new Suite(1, 300);

            Reception.SendRoomService(s);
        }


       
    }
}
