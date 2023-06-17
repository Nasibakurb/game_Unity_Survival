using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletAttack : MonoBehaviour {
    public GameObject AI;
    public GameObject triggerweapon;
 
	void Start () {
        triggerweapon.SetActive(false);
    }
 
	void Update () {
		
	}
    private void OnTriggerEnter(Collider col)
    {
     if (col.tag == "Player")
        {
            AI.GetComponent<Animator>().SetTrigger("Attack");
            triggerweapon.SetActive(true);
        }        
    }                                                              //видит, атакует. бежит не атакует 
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            AI.GetComponent<Animator>().SetTrigger("Move");
            triggerweapon.SetActive(false);
        }
    }
    }
