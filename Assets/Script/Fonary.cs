using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonary : MonoBehaviour {
 
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;

    }
}
