using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Konec : MonoBehaviour {
    [Header("Загружаемая сцена")]
    public int sceneID;
    private bool up;
    private float time;
    void Start()
    {

    }

    void Update()
    {
        if (up == true)
        {
            time += 0.1f;
            if (time >= 2)
            {
                Destroy(gameObject); //табл исчезает
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadSceneAsync(sceneID);
        }
    }
}
