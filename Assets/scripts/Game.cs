using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using level;

namespace game
{
    public class Game:Level
    {
        private int x=-240;
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
        
        public void mixItems(List<GameObject> puzzleItems)
        {   
            System.Random rand = new System.Random();  
            int index = rand.Next(puzzleItems.Count());  
            Debug.Log(index);
        }
    }
}