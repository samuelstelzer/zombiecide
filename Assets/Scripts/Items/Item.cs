using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character = Assets.Units.Characters.Character;
using Tile = Assets.Board.Tiles.Tile;

namespace Assets.Items
{
    public class AbstractItem
    {
        public string itemName;
    }

    public abstract class Consumable : AbstractItem
    {
        public string effectDescription;

        /// <summary>
        /// Consume the item and apply the effect to the character
        /// </summary>
        public void consume(Character character)
        {
            // TODO
            // applyEffect(character);
        }
    }

    public enum EquipmentSlot
    {
        Hand,
        Armor,
        Backpack
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
            int roll = UnityEngine.Random.Range(1, 7);
            return roll >= armorThreshold;
        }
    }

    public abstract class Shield : Equippable
    {
        public int armorThreshold;
        public EquipmentSlot slot = EquipmentSlot.Hand;

        public bool checkBlock()
        {
            int roll = UnityEngine.Random.Range(1, 7);
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
                int roll = UnityEngine.Random.Range(1, 7);
                if (roll >= hitThreshold)
                {
                    hits++;
                }
            }

            return hits;
        }

        public bool checkOpenDoor()
        {
            int roll = UnityEngine.Random.Range(1, 7);
            return roll >= openDoorThreshold;
        }
    }

}