using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestForLVL2 : MonoBehaviour {
    public GameObject Quest;
 
	void Start () {
    
    }
 
	void Update () {
        if (Quest == true) { Cursor.visible = true;  }

    }
}
