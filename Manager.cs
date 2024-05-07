using System;

namespace RandomItems
{
        public abstract class Manager
    {
        protected abstract Item GetItemType(string itemType);

        public Item ManageItems(string itemType)
        {
            Item item = GetItemType(itemType);
            item.UseItem();
            return item;
        }

    }
}