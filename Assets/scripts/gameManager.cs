using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game;

public class gameManager : MonoBehaviour
{
    public List<GameObject> slotList = new List<GameObject>();

    public int level;
    Game gameObj = new Game();

    void Start()
    {
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
