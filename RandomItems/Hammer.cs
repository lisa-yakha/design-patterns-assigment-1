using System;

namespace RandomItems
{
    public class Hammer : Item
    {
        public int attackValue{ get; set; }
        public override void UseItem()
        {
            Console.WriteLine("Hammer used");
        }
    }
}