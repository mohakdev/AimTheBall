using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadingLevel : MonoBehaviour
{
    string LevelToLoad;
    public void LevelLoading()
    {
        GameObject TextObj = transform.Find("Text").gameObject;
        Text TextComponent = TextObj.GetComponent<Text>();
        LevelToLoad = TextComponent.text;
        //Now LevelToLoad has the level the button has to load
        SceneManager.LoadScene(LevelToLoad);
    }
}
