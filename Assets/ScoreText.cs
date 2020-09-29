using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private TextMesh scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.text = "Wynik: " + ScoreScript.Score;
    }
    
}
