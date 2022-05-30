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

    private void Start()
    {
        settings.SetActive(false);
        about.SetActive(false);

    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void SettingsBack()
    {
        settings.SetActive(false);
        about.SetActive(false);
        menu.SetActive(true);
    }

    public void AboutBack()
    {
        about.SetActive(false);
        settings.SetActive(false);
        menu.SetActive(true);
    }

    public void Settings()
    {
        menu.SetActive(false);
        about.SetActive(false);
        settings.SetActive(true);
        
    }

    public void About()
    {
        menu.SetActive(false);
        settings.SetActive(false);
        about.SetActive(true);

    }

}
