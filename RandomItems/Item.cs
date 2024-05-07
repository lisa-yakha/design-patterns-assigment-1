using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomItems
{
    public abstract class Item
    {
        public string name {get; set; }
        public int id {get; set; }

        public abstract void UseItem();
    }
}