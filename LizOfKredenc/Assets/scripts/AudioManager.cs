using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    


    public AudioClip flash;
    public AudioClip speed;
    public AudioClip projectile;
    public AudioClip charge;
    public AudioClip perkMove;
    public AudioClip perkSelect;
    public AudioClip music;
    public AudioClip blast;

    private void Awake()
    {

        DontDestroyOnLoad(gameObject);

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
            
        }
    
    }
}
