using System;

namespace RandomItems
{
    public class ItemGenerator : Manager
    {
        protected override Item GetItemType(string itemType)
        {
            Item currentItem = null;

            switch(itemType)
            {
                case "hammer":
                    currentItem = new Hammer();
                    break;
                case "shield":
                    currentItem = new Shield();
                    break;
                default:
                    throw new ArgumentException("Wrong item type");
            }
            return currentItem;

        }
    }

}