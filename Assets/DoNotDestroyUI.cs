using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyUI : MonoBehaviour
{
    private void Awake ()
    { 
        GameObject[] uiObj = GameObject.FindGameObjectsWithTag("in game ui");
        DontDestroyOnLoad(this.gameObject);
    }
}
