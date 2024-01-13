using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character = Assets.Units.Characters.Character;
using DamageDealing = Assets.Items.DamageDealing;


namespace Assets.Board.Collectables
{
    public abstract class Collectable : MonoBehaviour
    {
        public string collectableName;

        public abstract void collect(Character character);
    }

    public enum TargetColor
    {
        Blue,
        Red,
        Yellow,
        Orange,
        Green,
        Purple
    }

    public abstract class Target : Collectable
    {
        public int adrenalineReward;
        public TargetColor targetColor;

        public override void collect(Character character)
        {
            character.currentAdrenalineLevel += adrenalineReward;
        }
    }

    public class VaultArtifact : Collectable
    {
        public DamageDealing damageDealing;

        public override void collect(Character character)
        {
            // TODO
            // implement
        }
    }
}
