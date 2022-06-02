using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject settings;
    [SerializeField]
    GameObject about;
    
    GameObject audioManager;
    AudioManager sounds;
    AudioSource source;



    private void Start()
    {
        settings.SetActive(false);
        about.SetActive(false);
        audioManager = GameObject.Find("AudioManager");
        sounds = audioManager.GetComponent<AudioManager>();
        source = audioManager.GetComponent<AudioSource>();


    }
    public void LoadGame()
    {
        source.PlayOneShot(sounds.perkSelect);
        SceneManager.LoadScene("Game");
    }
    public void SettingsBack()
    {
        source.PlayOneShot(sounds.perkSelect);
        settings.SetActive(false);
        about.SetActive(false);
        menu.SetActive(true);
    }

    public void AboutBack()
    {
        source.PlayOneShot(sounds.perkSelect);
        about.SetActive(false);
        settings.SetActive(false);
        menu.SetActive(true);
    }

    public void Settings()
    {
        source.PlayOneShot(sounds.perkSelect);
        menu.SetActive(false);
        about.SetActive(false);
        settings.SetActive(true);
        
    }

    public void About()
    {
        source.PlayOneShot(sounds.perkSelect);
        menu.SetActive(false);
        settings.SetActive(false);
        about.SetActive(true);

    }

}
