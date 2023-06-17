using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {
 
    public GameObject myPlayer;
    public float distance = 100;
   
 
    void LateUpdate()
    {
        if (myPlayer == true)
        {
            {
                transform.position = myPlayer.transform.position + Vector3.up * distance;

            }
        }
        else { }
    }
    }

