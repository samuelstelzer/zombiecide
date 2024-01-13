using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zombie = Assets.Units.Zombies.AbstractZombie;
using Item = Assets.Items.AbstractItem;
using Consumable = Assets.Items.Consumable;
using Equippable = Assets.Items.Equippable;
using Tile = Assets.Board.Tiles.Tile;
using Door = Assets.Board.Doors.Door;
using Collectable = Assets.Board.Collectables.Collectable;

namespace Assets.Units.Characters
{
    public class Backpack
    {
        public int slots;
        public Item[] items;
    }


    public class Inventory
    {
        public Item leftHand;
        public Item rightHand;
        public Item armor;
        public Backpack backpack;
    }

    public class Character : MonoBehaviour
    {
        public string characterName;
        public int currentHealthPoints;
        public int maxHealthPoints;
        public int currentAdrenalineLevel;
        public int maxAdrenalineLevel;
        public int currentActions;
        public int maxActions;
        public Inventory inventory;

        public void takeDamage(int damage)
        {
            currentHealthPoints -= damage;
        }

        public void heal(int heal)
        {
            currentHealthPoints += heal;
        }

        public void gainAdrenaline(int adrenaline)
        {
            currentAdrenalineLevel += adrenaline;
        }

        /// Actions
        public void move(Tile tile)
        {
            currentActions--;
        }

        public void attack(Zombie zombie)
        {
            currentActions--;
        }

        public void openDoor(Door door)
        {
            currentActions--;
        }

        public void search()
        {
            // var item = ItemDrawPile.drawItem();
            currentActions--;
        }
        public void pickUp(Collectable collectable)
        {
            currentActions--;
        }

        public void consumeItem(Consumable item)
        {
            item.consume(this);
            // ItemDiscardPile.discard(item);
            currentActions--;
        }

        public void reorganizeInventory()
        {
            currentActions--;
        }

        public void equipItem(Equippable item)
        {
            // item.equip(this);
        }
    }
}