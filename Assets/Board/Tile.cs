using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Board.Tile
{
    public abstract class Tile : MonoBehaviour
    {
        public Tile[] neighbors;

        public void addNeighbor(Tile neighbor)
        {
            neighbors.Add(neighbor);
        }
    }

    public class StreetTile : Tile
    {
    }

    public class RoomTile : Tile
    {
    }

    public class VaultTile : Tile
    {
    }
}

