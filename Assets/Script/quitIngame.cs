using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class quitIngame : MonoBehaviour
{

 
    public void ExitGame()
    { 
        Application.LoadLevel(1);
    }
}
