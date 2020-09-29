using UnityEngine;


public class SamolotAnimator : MonoBehaviour
{

    public void Zespawnuj()
    {

        if (ScoreScript.SmiecCount < 16)
        {
        
            this.transform.Find("MultipleSmiecSpawner").GetComponent<MultipleSmiecSpawner>().SpawnWaves(16-ScoreScript.SmiecCount);
            //ScoreScript.gameStarted = true;
        }

    }
  
}
