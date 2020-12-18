using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game;

public class gameManager : MonoBehaviour
{
    [Header("slots | enfazla 18")]
    public List<GameObject> slotList = new List<GameObject>();

    [Header("puzzle items | enfazla 18 ")]
    public List<GameObject> itemList = new List<GameObject>();
    //rast gele karıştırmak için itemleri alıyorum.

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
