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
    public GameObject  gameCanvas;
    public GameObject  completeCanvas;
    public GameObject  menuCanvas;



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
            gameCanvas.SetActive(false);
            completeCanvas.SetActive(true);


        }
    }

    public void nextLevel(){
        gameObj.nextLevel();
    }

    public void toggleMenu(){
        gameCanvas.SetActive(!gameCanvas.activeInHierarchy);
        
        menuCanvas.SetActive(!menuCanvas.activeInHierarchy);

    }

    public void quitGame(){
        Application.Quit();
    }

}
