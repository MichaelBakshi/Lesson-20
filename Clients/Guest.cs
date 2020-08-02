using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    public class Guest
    {
        private int id;
        private string name;

        public int GetId()
        {
            return id;
        }

        private string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return $"[Name:]:{name}, [id:]:{id}";
        }
    }
}
