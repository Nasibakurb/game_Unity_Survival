using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strelyba : MonoBehaviour
{
    public Text text;
    public int AmmoCount; //Патронов в обоймах
    public int ColP; //Кол-во патроеов
    public int ColPVO; //Кол-во патронов в 1ой обойме
    public AudioClip Fire; // Звук выстрела
    public float ShootSpeed; // Скорострельность
    public float ReloadSpeed; // Скорость Перезарядки
    public AudioClip Reload; // Звук перезарядки
    public float ReloadTimer = 0.0f; // Время перезарядки
    public float ShootTimer = 0.0f; // Время выстрелa
    public Transform Patron; // Патрон
    public GameObject avtomat;      
  
    void Start()
    {

    }

 
    void Update()
    {
        // стрельба 
        if (Input.GetMouseButton(0) & ColP > 0 & ReloadTimer <= 0 & ShootTimer <= 0)
        {
            avtomat.GetComponent<Animator>().SetTrigger("Fire");
            Transform BulletInstance = (Transform)Instantiate(Patron, GameObject.Find("Spawn").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
            ColP = ColP - 1;
            GetComponent<AudioSource>().PlayOneShot(Fire);
            ShootTimer = ShootSpeed;
          
        }
        if (ShootTimer > 0)
        {
            ShootTimer -= Time.deltaTime;
        }
          //перезарялка
        if (Input.GetKeyDown(KeyCode.Q))
        {
            avtomat.GetComponent<Animator>().SetTrigger("Perez");
            ReloadTimer = ReloadSpeed;
            ColP = ColPVO;
            GetComponent<AudioSource>().PlayOneShot(Reload);
            {
                if (ShootTimer > 0)
                {
                    ShootTimer -= Time.deltaTime;
                }
            }
        }

        if (ReloadTimer > 0)
        {
            ReloadTimer -= Time.deltaTime;
        }
        text.text = ColP+"/10";
    }
}