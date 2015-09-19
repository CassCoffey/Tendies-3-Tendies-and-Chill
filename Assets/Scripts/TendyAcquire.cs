using UnityEngine;
using System.Collections;

public class TendyAcquire : MonoBehaviour {

    public GameObject tendy;

	void OnTriggerEnter (Collider collision)
    {
        if (collision.tag == "Mouth" && collision.transform.childCount == 0)
        {
            GameObject tendyInst = (GameObject)GameObject.Instantiate(tendy, collision.transform.position, Quaternion.Euler(0, 270, 0));
            tendyInst.transform.SetParent(collision.transform);
        }
	}
}
