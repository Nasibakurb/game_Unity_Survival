using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SaveGame : MonoBehaviour {
   
    public GameObject player;
     [System.Serializable]
     public class Position
    {
        public float x;
        public float y;
        public float z;
    }     // сохранения по позициям в папку 
   public void Save () {
        Position position = new Position();
        position.x = player.transform.position.x;
        position.y = player.transform.position.x;
        position.z = player.transform.position.x;
        if (!Directory.Exists(Application.dataPath + "/saves"))
            Directory.CreateDirectory(Application.dataPath+"/saves");
        FileStream fs = new FileStream(Application.dataPath + "/saves/save.sv", FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, position);
        fs.Close();

    }
 

}
