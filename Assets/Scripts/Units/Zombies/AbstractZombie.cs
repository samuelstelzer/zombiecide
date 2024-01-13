using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character = Assets.Units.Characters.Character;
using Tile = Assets.Board.Tiles.Tile;

namespace Assets.Units.Zombies
{
    public abstract class AbstractZombie : MonoBehaviour
    {
        public string zombieName;
        public int healthPoints;
        public int currentActions;
        public int maxActions;
        public int attackDamage;

        public void attack(Character character)
        {
            character.takeDamage(attackDamage);
            currentActions--;
        }
        public void move(Tile tile)
        {
            currentActions--;
        }
        public void findTarget()
        {

        }
    }
}