using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game;

public class gameManager : MonoBehaviour
{
    [Header("slots")]
    public List<GameObject> slotList = new List<GameObject>();

    [Header("puzzle items ")]
    public List<GameObject> itemList = new List<GameObject>();
    

    public int level;
    Game gameObj = new Game();

    void Start()
    {
        gameObj.mixItems(itemList);
    }

    void Update()
    {
        gameObj.checkSlot(slotList);
        if (gameObj.complate)
        {
            Debug.Log("********Oyun Bitti !!*********");
            
        }
    }

}
