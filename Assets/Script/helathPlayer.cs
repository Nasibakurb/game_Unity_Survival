using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helathPlayer : MonoBehaviour {
    public int health;
    public  Slider slider;
    public Text txt;
    public GameObject endText;
    public GameObject Camera2;
    public GameObject pricel;
    public GameObject bloodyscreen;
    public GameObject bloodyscreen1;
    void Start () {
		
	}
       // После смерти
	void Update () {
        slider.value = health;

        if (health <= 0)
        {
            Cursor.visible = true;
            endText.SetActive(true);
            Camera2.SetActive(true);
           Destroy(gameObject);          //перс тело дистрой
            pricel.SetActive(false);
            Destroy(bloodyscreen1);
            Destroy(bloodyscreen);
        }
        txt.text=health+"%";

        if (transform.position.y < 0)
        {                          //Огран. Выход за гран.
            health = health - 10;
}
    }
}
