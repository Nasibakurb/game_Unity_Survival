using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPatron : MonoBehaviour
{
    private float lofeTime = 5;
    private void OnCollisionEnter(Collision collision)
    {   
        if (gameObject.name == "Potron(Clone)")    // При столкновение патрон дистрой
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

        if (gameObject.name == "Potron(Clone)") //5 сек
        {
            Destroy(gameObject, lofeTime);
        }
    }
}