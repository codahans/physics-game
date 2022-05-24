using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : MonoBehaviour
{
    public GameObject music;
    public void cancelMusic ()
    {
        Destroy(music);
    }
}
