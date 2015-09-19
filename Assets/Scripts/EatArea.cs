using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EatArea : MonoBehaviour {

    public Text scoreText;
    private int score = 0;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Mouth" && collision.transform.childCount > 0)
        {
            GetComponent<AudioSource>().Play();
            collision.transform.GetChild(0).GetComponent<Tendy>().LerpAndDestroy();
            score += collision.transform.GetChild(0).GetComponent<Tendy>().worth;
            scoreText.text = score.ToString();
        }
    }
}
