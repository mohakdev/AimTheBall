using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class LevelClearedUI : MonoBehaviour
{
    string NextScene;
    public bool isLastLevel;
    public void LoadNextLevel()
    {
        int SceneName = int.Parse(SceneManager.GetActiveScene().name);
        int NextLevelName = SceneName + 1;
        NextScene = NextLevelName.ToString();
        if (!isLastLevel)
        {
            SceneManager.LoadScene(NextScene);
        }
        else
        {
            print(isLastLevel);
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
