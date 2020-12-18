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
        private float x=100f;
        private float y=80f;

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
            if (puzzleItems.Count()>0)
            {
                System.Random rand = new System.Random();  
                int index = rand.Next(puzzleItems.Count());  
                //Debug.Log(index);
                //Debug.Log(puzzleItems[index].transform.position);
                puzzleItems[index].transform.position = new Vector2(x, y);
                puzzleItems.RemoveAt(index);
                x+=130;//120 item weight 10 margin
                mixItems(puzzleItems);
            }
        }
    }
}