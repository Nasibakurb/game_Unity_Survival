using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodyScreen : MonoBehaviour
{
    public GameObject healthMonstr; 
    public GameObject bloodyScree;
 
    void Start()
    {
        bloodyScree.SetActive(false);
    }

 
    void Update()
    {
        if (healthMonstr == false)
        {
          
                bloodyScree.SetActive(false);
            }
     
        }
    }
 
 