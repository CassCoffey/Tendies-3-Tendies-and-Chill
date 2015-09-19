using UnityEngine;
using System.Collections;

public class TendyDip : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Mouth" && collision.transform.childCount > 0)
        {
            GetComponent<AudioSource>().Play();
            collision.transform.GetChild(0).GetComponent<Tendy>().Dip();
        }
    }
}
