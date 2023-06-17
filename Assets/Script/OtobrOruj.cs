using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtobrOruj : MonoBehaviour {

    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject Weapon3;
    public GameObject Weapon4;
    public GameObject Weapon5; //колич. паатронов
    void Start()
    {
    
    }
 
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
     
            Weapon1.SetActive(true);
            Weapon2.SetActive(true);
            Weapon3.SetActive(false);
            Weapon4.SetActive(false);
            Weapon5.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapon1.SetActive(false);
            Weapon2.SetActive(false);
            Weapon3.SetActive(true);
            Weapon4.SetActive(true);
            Weapon5.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Weapon1.SetActive(false);
            Weapon2.SetActive(false);
            Weapon3.SetActive(false);
            Weapon4.SetActive(false);
            Weapon5.SetActive(false);
        }
    }
}