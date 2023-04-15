using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaslangicMenuleriKodlari : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitAnaMenu()
    {
        Application.Quit();
    }
}
