using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class MenuButton : MonoBehaviour {
    public GameObject settings;
    public GameObject Player;
    public GameObject instruction;
    [System.Serializable]
    public class Position
    {
        public float x;
        public float y;
        public float z;
    }

    public void StartGame()
    {
        Application.LoadLevel(3);
    }
    public void LoidGame()
    {
        // загрузить файл по позициям 
        if (File.Exists(Application.dataPath + "/saves/save.sm"))
        {
           FileStream fs = new FileStream(Application.dataPath + "/saves/save.sm", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                Position pos = (Position)formatter.Deserialize(fs);
                Player.transform.position = new Vector3(pos.x, pos.y, pos.z);
            }
            catch (System.Exception e)
            {
                Debug.Log(e.Message);
            }
           
            finally
            {
                fs.Close();
            }
        }
        else
        {
            Application.Quit();
        }
        Player.GetComponent<helathPlayer>().health = PlayerPrefs.GetInt("health"); // сохр. здоровья
    }
    public void OnSave()
    {
        Position position = new Position();
        position.x = Player.transform.position.x;
        position.y = Player.transform.position.y;
        position.z = Player.transform.position.z;
        if (!Directory.Exists(Application.dataPath + "/saves"))
            Directory.CreateDirectory(Application.dataPath + "/saves");
        FileStream fs = new FileStream(Application.dataPath + "/saves/save.sm", FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, position);
        fs.Close();

        PlayerPrefs.SetInt("health", Player.GetComponent<helathPlayer>().health);
    }

    public void Settings()
    {
        settings.SetActive(!settings.activeSelf);
    }

    public void Ixnstruction() { 
    
        instruction.SetActive(!instruction.activeSelf);
    }
    public void ExitGame() {
        Application.Quit();
    }
}
