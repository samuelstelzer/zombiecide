using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Board.Tiles
{
    public abstract class Tile : MonoBehaviour
    {
        public List<Tile> neighbors;

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

