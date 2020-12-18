using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace level
{
    public class Level
    {
        public void nextLevel()
        {   
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}