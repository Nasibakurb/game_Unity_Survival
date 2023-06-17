using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class MenuActive : MonoBehaviour
{
    public GameObject menu;
    public static bool GameIsPouse = false;
    [SerializeField]
    private GameObject player;
    Pers controller;
 
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        controller = player.GetComponent<Pers>();
  
    }
    void Update()
    {
         
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPouse) {
                Resume(); }
               else {
                Pouse();
            }
         }

    }
  void Resume()
    {
        menu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1f;
        GameIsPouse = false;
        controller.enabled = true; // включение скрипта
 
    }
 void Pouse()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
        
        Cursor.visible = true;
        GameIsPouse = true;
        controller.enabled = false;
    
        

    }
}
 
