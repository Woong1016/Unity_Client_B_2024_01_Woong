using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGameSystem : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Inventory.AddItem(sword);
            Debug.Log("inventory : "+ )
        }    

        
    }

    public class Item
    {
        internal string Name;

        private int index
        {
            get { return index; }
            set { index = value; }
        }

        
        private string name
        {
            get { return name; }
            set { name = value; }
        }
        private ItemType type
        {
            get { return type; }
            set { type = value; }
        }
        
        private Sprite Image
        {
            get { return Image; }
            set { Image = value; }
        }



        public Item (int index, string name , ItemType type)
        {
            this.index = index;
            this.name = name;
            this.type = type;
        }


    }

    public enum ItemType
    {
        Weapon,
        Armor,
        Potion,
        QuestItem,

    }
    public class Inventory
    {
        private Item[] items = new Item[16];

        public Item this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }



        public bool AddItem(Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    return true;
                }
            }
        }

        public void RemoveItem(Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == item)
                {
                    items[i] = null;
                        break;

                }
            }
        }


        public int ItemCount
        {
            get
            {
                int count = 0;
                foreach (Item item in items)
                {
                    if (item != null)
                        count++;
                }
                return count;
            }
        }



        private Inventory inventory = new Inventory();

        Item sword = new Item(0, "Sword", ItemType.Weapon);
        Item Armor = new Item(0, "Sword", ItemType.Armor);


        private string GetInventoryAsString()
        {
            string result = "";
            for(int i = 0; i < inventory.ItemCount; i ++)
            {
                if( inventory[i] != null)
                {
                    result += inventory[i].Name + ",";

                }
            }
            return result.TrimEnd(',');
        }

    }
    












}
