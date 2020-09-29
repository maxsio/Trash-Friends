using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int SmiecCount;
    public static int Score;
    public static float currentTime;
    public static float startingTime;
    public static bool gameStarted;
    public static bool dobryRzutRight;
    public static bool zlyRzutRight;
    public static bool dobryRzutLeft;
    public static bool zlyRzutLeft;

    void Awake()
    {
     SmiecCount = 0;
     Score = 0; 
     currentTime = 0; 
     startingTime = 120;
     gameStarted = true;
     dobryRzutRight = false;
     zlyRzutRight = false;
     dobryRzutLeft = false;
     zlyRzutLeft = false;
}
    void Start()
    {
        if(SceneManager.GetActiveScene().name.Equals("Trash Friends Play"))
        {
            currentTime = startingTime;
        }
    }

    void Update()
    {
        if(gameStarted && currentTime >0) currentTime -= 1 * Time.deltaTime;
        SmiecCount = GameObject.FindGameObjectsWithTag("Smiec").Length;
    }
}
