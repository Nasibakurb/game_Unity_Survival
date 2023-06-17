using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class EfectBlood : MonoBehaviour {

 public Material ShaderTexture;
    void InRenderImage(RenderTexture cameraViev, RenderTexture shaderView)
    { 
        Graphics.Blit(cameraViev,shaderView,ShaderTexture);

    }
}
