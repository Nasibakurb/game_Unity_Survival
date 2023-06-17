using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    public int LevelCount;
 


    void Start()
    {
    

    }
    void Update()
    {

    }
     // порт перса на данную перееменную
    void OnTriggerEnter(Collider col)
    {
        if (LevelCount == 4) {
            if (col.tag == "Player")
            {

                SceneManager.LoadScene(LevelCount);
            }
        }
    }

	 
	 
}
