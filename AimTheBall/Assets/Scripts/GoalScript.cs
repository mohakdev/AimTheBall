using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    int LevelUnlocked;
    Player PlayerScript;
    Rigidbody2D RigidbodyPlayer;
    public GameObject Player;
    public GameObject LevelCleared;
    public GameObject LevelFailed;
    bool LevelPassed;
    private void Awake()
    {
        PlayerScript = Player.GetComponent<Player>();
        RigidbodyPlayer = Player.GetComponent<Rigidbody2D>();
        StartCoroutine(IfPlayerStopped());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            RigidbodyPlayer.velocity = new Vector2(0, 0);
            LevelCleared.SetActive(true);
            LevelPassed = true;
            LevelUnlocked = PlayerPrefs.GetInt("LevelUnlocked", 1);
            int SceneName = int.Parse(SceneManager.GetActiveScene().name);

            if (LevelUnlocked.Equals(SceneName))
            {
                LevelUnlocked += 1;
                PlayerPrefs.SetInt("LevelUnlocked", LevelUnlocked);
            }
        }
    }
    IEnumerator IfPlayerStopped()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            //This will check if player started moving and after a while he stopped 
            //without hitting the target
            if (PlayerScript.MovementStarted && !LevelPassed && RigidbodyPlayer.velocity.magnitude < 0.7)
            {
                LevelFailed.SetActive(true);
            }
        }
    }

}
