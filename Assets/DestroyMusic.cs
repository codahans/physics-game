using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : MonoBehaviour
{
    public void cancelMusic ()
    {
        Destroy(GameObject.FindGameObjectWithTag("in game music"));
    }
}
