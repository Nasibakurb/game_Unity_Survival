using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class Nastrouki : MonoBehaviour {
    public GameObject QuestForLevel;
    public Slider Soundslider;
    public GameObject menu;

    public Dropdown dropdown;
    public Toggle toggle; //галочка
    Resolution[] res;
    void Start () {
        Screen.fullScreen = true;
        toggle.isOn = false;
        Resolution[] resolution = Screen.resolutions; // врнт
        res = resolution.Distinct().ToArray(); // без повтр
        string[] strRes = new string[res.Length];
        for(int i=0; i<res.Length; i++)
        {
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString(); //передача без частоты
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(strRes.ToList());
        Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);//макс . разр
  }
    public void SetRes()
    {
        Screen.SetResolution(res[dropdown.value].width, res[dropdown.value].height, Screen.fullScreen);
    } 
    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
    }

	void Update () {
        AudioListener.volume = Soundslider.value; // настр звука
	}
    // настройки графики
    public void LowQuality()
    {
        QualitySettings.SetQualityLevel(0, true);
    }
    public void MediumQuality()
    {
        QualitySettings.SetQualityLevel(2, true);
    }
    public void UltraQuality()
    {
        QualitySettings.SetQualityLevel(4, true);
    }
 
    public void ExitGame()
    {
         Application.LoadLevel(1);
    }

    public void QuestForLevel2() // квест
    {
        Destroy(QuestForLevel);
        Cursor.visible = false;
    }

}
