using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Board.Collectable
{
    public abstract class Collectable : MonoBehaviour
    {
        public string collectableName;

        public abstract void collect(Character character);
    }

    enum TargetColor
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
            character.adrenaline += adrenalineReward;
        }
    }

    public class VaultArtifact : Collectable
    {
        public DamageDealing damageDealing;

        public override void collect(Character character)
        {
            character.reorganizeBackpack(damageDealing);
        }
    }
}
