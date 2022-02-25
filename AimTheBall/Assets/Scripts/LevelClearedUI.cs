using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class LevelClearedUI : MonoBehaviour
{
    string NextScene;
    public void LoadNextLevel()
    {
        int SceneName = int.Parse(SceneManager.GetActiveScene().name);
        int NextLevelName = SceneName + 1;
        NextScene = NextLevelName.ToString();
        SceneManager.LoadScene(NextScene);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
