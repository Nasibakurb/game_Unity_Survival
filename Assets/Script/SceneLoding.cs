using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoding : MonoBehaviour {
    [Header("Загружаемая сцена")]
    public int sceneID;
    [Header("Остальные объекты")]
    public Image loadingImg;
    public Text progressText;
 
    void Start() {
        StartCoroutine(AsyncLoad());
    }
    IEnumerator AsyncLoad()
    {
        AsyncOperation opertion = SceneManager.LoadSceneAsync(sceneID);
        while (!opertion.isDone)
        {  // вовремя загрузки  проценты доходят до 100 и кружок
            float progress = opertion.progress / 0.9f;
            loadingImg.fillAmount = progress;  
           progressText.text = string.Format("{0:0}%", progress * 100);
            
            yield return null;
        }
    }

 
	void Update () {
		
	}
}
