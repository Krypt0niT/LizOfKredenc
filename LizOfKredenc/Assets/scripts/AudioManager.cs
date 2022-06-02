using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    
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
        print(SceneManager.GetActiveScene().name);
        audioSource = GetComponent<AudioSource>();
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            slider = GameObject.Find("EffectsVolume").GetComponent<Slider>();
            

        }


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
