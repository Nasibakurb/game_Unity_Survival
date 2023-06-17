using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;
public class Predistor : MonoBehaviour
{
    public int sceneID;
    public VideoPlayer videop;
    Slider taisn;
    private void Start()
    {
        taisn = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        taisn.value = (float)videop.frame / (float)videop.frameCount;
        if ((float)videop.frame / (float)videop.frameCount >= 1) { Application.LoadLevel(1); }
        if (Input.GetKeyDown(KeyCode.Escape))
      {
            Application.LoadLevel(1);
        }
    }
  
}
