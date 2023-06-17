using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamegger : MonoBehaviour {
 //дамаг ПО монстру
	void Start () {
		
	}
	 
	void Update () {
		
	}
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "MonsterAI")
        {
            col.GetComponent<Monstr>().healthMonster -= 10;
        }
 
    }
}
