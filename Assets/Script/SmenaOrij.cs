using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmenaOrij : MonoBehaviour
{
    public GameObject menu;
    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject qrabot;
 
    void Start()
    {
        qrabot.SetActive(false);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            qrabot.SetActive(false);
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);
           }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            qrabot.SetActive(true);
            Weapon2.SetActive(true);
            Weapon1.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            qrabot.SetActive(false);
            Weapon2.SetActive(false);
            Weapon1.SetActive(false);
        } 
    }  
    }
