using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tendy : MonoBehaviour {

    public int worth = 1;
    public int dips = 0;
    private bool eating = false;
    private float percent = 0;

    public List<AudioClip> announcer;

	public void Dip()
    {
        if (dips == 5 || dips == 10)
        {
            GameObject.Find("announcer").GetComponent<AudioSource>().PlayOneShot(announcer[Random.Range(0, announcer.Count)]);
        }

        if (dips < 10)
        {
            dips++;
            worth += dips;
        }
        else
        {
            worth = 1;
        }
    }

    public void LerpAndDestroy()
    {
        Destroy(gameObject, 0.5f);
        eating = true;
    }

    void FixedUpdate()
    {
        if (eating)
        {
            transform.position = Vector3.Lerp(transform.parent.position, transform.parent.position - (transform.parent.forward / 10), percent);
            percent += Time.deltaTime * 2;
        }
    }
}
