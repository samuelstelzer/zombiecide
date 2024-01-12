using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Items
{
    public class AbstractItem : ScriptableObject
    {
        public string itemName;
    }

    public abstract class Consumable : AbstractItem
    {
        public string effectDescription;

        /// <summary>
        /// Consume the item and apply the effect to the character
        /// </summary>
        public void consume(Character character);
    }

    public abstract class Equippable : AbstractItem
    {
    }

    public abstract class Throwable : Equippable
    {
        public EquipmentSlot slot = EquipmentSlot.Hand;

        public void doThrow(Tile tile)
        {

        }
    }

    public abstract class Armor : Equippable
    {
        public int armorThreshold;
        public EquipmentSlot slot = EquipmentSlot.Armor;

        public bool checkBlock()
        {
            Random = new Random();
            int roll = Random.Next(1, 6);
            return roll >= armorThreshold;
        }
    }

    public abstract class Shield : Equippable
    {
        public int armorThreshold;
        public EquipmentSlot slot = EquipmentSlot.Hand;

        public bool checkBlock()
        {
            Random = new Random();
            int roll = Random.Next(1, 6);
            return roll >= armorThreshold;
        }
    }

    public enum DamageType
    {
        Ranged,
        Melee

    }

    public abstract class DamageDealing : Equippable
    {
        public int range;
        public int numberOfDice;
        public int hitThreshold;
        public int damageValue;
        public bool canDualWield;
        public bool attacksSilently;
        public bool canOpenDoor;
        public bool opensDoorSilently;
        public int openDoorThreshold;
        public EquipmentSlot slot = EquipmentSlot.Hand;
        public DamageType damageType;
        public bool isSpell;

        public int checkHits()
        {
            var hits = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                Random = new Random();
                int roll = Random.Next(1, 6);
                if (roll >= hitThreshold)
                {
                    hits++;
                }
            }

            return hits;
        }

        public bool checkOpenDoor()
        {
            Random = new Random();
            int roll = Random.Next(1, 6);
            return roll >= openDoorThreshold;
        }
    }

}