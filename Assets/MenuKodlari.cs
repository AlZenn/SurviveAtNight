using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuKodlari : MonoBehaviour
{
    public GameObject menu;
    public GameObject spawner;
    public void ReloadCurrentScene()
    {
        menu.SetActive(false);
        spawner.SetActive(true);
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
