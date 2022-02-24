using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelClearedUI : MonoBehaviour
{
    public void NextLevel()
    {
        //Load Next level here
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
