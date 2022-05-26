using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoadButton : MonoBehaviour
{
    public AudioSource music;
    public int level;
    public void loadLevel ()
    {
        SceneManager.LoadScene(level);
        if (level != 1)
        {
            music.Play();
            DontDestroyOnLoad(music);
        }
    }
}
