using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelect : MonoBehaviour
{
    int LevelUnlocked;
    public int TotalLevels;
    public GameObject LevelButton;
    public GameObject LevelGrid;
    void Start()
    {
        int i = 1;
        LevelUnlocked = PlayerPrefs.GetInt("LevelUnlocked", 1);
        while (i <= TotalLevels)
        {
            //Getting all important things
            GameObject ButtonObject = Instantiate(LevelButton);
            Button ButtonComponent = ButtonObject.GetComponent<Button>();
            GameObject TextObject = ButtonObject.transform.Find("Text").gameObject;
            Text ButtonText = TextObject.GetComponent<Text>();
            GameObject LockIcon = ButtonObject.transform.Find("LockIcon").gameObject;
            ButtonObject.transform.SetParent(LevelGrid.transform, false);
            if (i <= LevelUnlocked)
            {
                ButtonText.text = i.ToString();
            }
            else
            {
                ButtonText.text = "";
                ButtonComponent.interactable = false;
                LockIcon.SetActive(true);
            }
            i++;
        }
    }
}
