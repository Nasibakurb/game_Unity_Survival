using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOtnimJ : MonoBehaviour
{
    public int valueDown; //сколько отнимает 
 
    void Start()
    {

    }
 
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<helathPlayer>().health -= valueDown;
        
        }
       
    }
    }

