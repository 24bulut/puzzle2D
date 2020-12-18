using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace game
{
    public class Game
    {

        public bool complate;
        public Game()
        {
            complate = false;
        }
        public void checkSlot(List<GameObject> puzzleSlots)
        {
            if (puzzleSlots.Exists(go => go.GetComponent<puzzleSlot>().matched != false))
                complate = true;
        }
    }
}