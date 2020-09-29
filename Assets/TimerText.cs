using UnityEngine;

public class TimerText : MonoBehaviour
{
    private TextMesh timeText;
    private bool soundPlayed=false;
    void Start()
    {
        timeText = GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreScript.currentTime>0) this.timeText.text = "Czas: " + ScoreScript.currentTime.ToString("0") + "s";
        else
        {
            this.timeText.text = "Koniec gry!";
            ScoreScript.gameStarted = false;
            if(!soundPlayed) GetComponent<AudioSource>().Play();
            soundPlayed = true;
        }

    }
}
