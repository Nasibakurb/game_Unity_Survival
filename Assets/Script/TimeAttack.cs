using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAttack : MonoBehaviour {
    public int timeStart;
    public int timeEnd;
 
	void Start () {
		
	}
 
	void Update () {
        timeStart += 1;
        if (timeStart >= timeEnd)
        {
            timeStart = 0; 
            gameObject.SetActive(false); //удар не проходит
        }
	}
}
