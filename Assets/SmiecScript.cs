using UnityEngine;
using UnityEngine.SceneManagement;

public class SmiecScript : MonoBehaviour
{
    public bool isZielony;
    public bool isNiebieski;
    public bool isZolty;
    public bool isBrazowy;
    public bool isCzarny;

    private void Dobry()
    {
        Destroy(this.gameObject);
        ScoreScript.Score += 1;
    }

    private bool isGood(Collider other)
    {
        if (((other.gameObject.tag == "ZielonySmiecPodstawka" && isZielony) ||
             (other.gameObject.tag == "NiebieskiSmiecPodstawka" && isNiebieski) ||
             (other.gameObject.tag == "ZoltySmiecPodstawka" && isZolty) ||
             (other.gameObject.tag == "BrazowySmiecPodstawka" && isBrazowy) ||
             (other.gameObject.tag == "CzarnySmiecPodstawka" && isCzarny))) 
            return true;
        else
        {
            return false;
        }
    }

    private bool isBad(Collider other)
    {
        if ((other.gameObject.tag == "ZielonySmiecPodstawka" && !isZielony ||
             (other.gameObject.tag == "NiebieskiSmiecPodstawka" && !isNiebieski) ||
             (other.gameObject.tag == "ZoltySmiecPodstawka" && !isZolty) ||
             (other.gameObject.tag == "BrazowySmiecPodstawka" && !isBrazowy) ||
             (other.gameObject.tag == "CzarnySmiecPodstawka" && !isCzarny)))
            return true;
        else return false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isGood(other) && ScoreScript.gameStarted)
            {
                Dobry();
                ScoreScript.dobryRzutRight = true;
                ScoreScript.dobryRzutLeft = true;
            }
        else if (other.gameObject.tag == "Podloga")
        {
            Destroy(this.gameObject);
        }
        else if (isGood(other) && !ScoreScript.gameStarted)
        {
            ScoreScript.dobryRzutRight = true;
            ScoreScript.dobryRzutLeft = true;
            Destroy(this.gameObject);
        }
            else if (isBad(other))
            {
                ScoreScript.zlyRzutRight = true;
                ScoreScript.zlyRzutLeft = true;
                Destroy(this.gameObject);
            }
            
            else if (other.gameObject.tag == "ResetGry")
            {
                SceneManager.LoadScene("Trash Friends Free");
            }
            else if (other.gameObject.tag == "StartGry")
            {
                SceneManager.LoadScene("Trash Friends Play");
                ScoreScript.currentTime = 120;
            }
    }
}
