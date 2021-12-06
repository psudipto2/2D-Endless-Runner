using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private static SoundController BackgroundMusic;
    private void Awake()
    {
        if (BackgroundMusic == null)
        {
            BackgroundMusic = this;
            DontDestroyOnLoad(BackgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
