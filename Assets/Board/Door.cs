using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tile = Assets.Board.Tile;

namespace Assets.Board.Door
{
    public enum DoorColor
    {
        Red,
        Blue,
        Green,
        Yellow,
        Purple
    }

    public enum DoorType
    {
        Normal,
        Vault
    }

    public class Door : MonoBehaviour
    {
        public DoorColor color;
        public DoorType type;

        public Tuple<Tile, Tile> connectedTiles;
        public bool isOpen;

        public void open()
        {
            tileOne = connectedTiles.Item1;
            tileTwo = connectedTiles.Item2;
            tileOne.addNeighbor(tileTwo);
            tileTwo.addNeighbor(tileOne);
            isOpen = true;
        }
    }
}