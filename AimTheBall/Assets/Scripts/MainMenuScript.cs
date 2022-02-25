using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject LevelSelect;
    public void PlayGame()
    {
        gameObject.SetActive(false);
        LevelSelect.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
