using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public GameObject SliderEner;
    public GameObject triggerDamage;
 
    void Start()
    {

    }
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))     //ЛКМ
        {
            gameObject.GetComponent<Animator>().SetTrigger("Attack");
            triggerDamage.SetActive(true);
            SliderEner.GetComponent<EnerjiPlayer>().stamina -= 5; // вычитании энергии
        }
    
        if (Input.GetButtonDown("Fire2"))
        {
            SliderEner.GetComponent<EnerjiPlayer>().stamina -= 10;
            gameObject.GetComponent<Animator>().SetTrigger("Attack1");
            triggerDamage.SetActive(true);
        }
         
        
    }
    }

