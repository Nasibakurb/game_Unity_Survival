using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnenaSL : MonoBehaviour {

    float hours = 5;
    float minutses = 45;
    public float speed;
    public GameObject PivotLS;
    private void FixedUpdate()
    {
        PivotLS.transform.Rotate(Vector3.right * 5 * Time.deltaTime);
        minutses = minutses + speed + Time.deltaTime;
        if (minutses >= 60)
        {
            hours = hours + 1;
            if (hours >= 24)
            {
                hours = 0;
            }
            minutses = 0;
        
    }

}
	
 
	void Update () {
		
	}
}
