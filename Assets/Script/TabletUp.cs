using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletUp : MonoBehaviour {
    public int upTablet;
    private float time;
    private bool up;
 
	void Start () {
		
	}
 
	void Update () {
		if (up == true)
        {
            time += 0.1f;
            if (time >= 1)
            {
                Destroy(gameObject); //табл исчезает
            }
        }
	}
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<helathPlayer>().health += upTablet;
            up = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;

        }
    }
}
