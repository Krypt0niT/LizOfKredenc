using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField]
    Slider slider;
    AudioSource audioSource;
    


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
        audioSource = GameObject.Find("AudioManager").GetComponent<AudioSource>();

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

    public void SliderChange()
    {
        audioSource.volume = slider.value;
    }
}
