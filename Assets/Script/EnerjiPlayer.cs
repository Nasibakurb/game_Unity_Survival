using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnerjiPlayer : MonoBehaviour {
    public Slider sliders;
    public float stamina;// общая энерг
    public GameObject stamiN;

    void Start () {
		
	}


    void Update()
    {
        sliders.value = stamina;
        if (Input.GetKey(KeyCode.R)) //восст энергии
        {
            stamina += 1f;
        }
        if (stamina > 100)
        {
            stamina = 100;
        }
        if (stamina < 0)
        {
            stamina = 0;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            stamina -= 6f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            stamina -= 2f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            stamina -= 2f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            stamina -= 2f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            stamina -= 2f * Time.deltaTime;
        }

        if (stamiN == true) {
            if (stamina <= 0)
            {
                stamiN.GetComponent<Pers>().speed = 5;
            }
            if (stamina >= 0)
            {         
            stamiN.GetComponent<Pers>().speed = 20;
           }
        }
        else { }



    }
    }

