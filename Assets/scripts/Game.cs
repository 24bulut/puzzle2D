using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
           if(puzzleSlots.All(go => go.GetComponent<puzzleSlot>().matched != false ))
                complate = true;
        }
    }
}