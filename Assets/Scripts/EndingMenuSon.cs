using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenuSon : MonoBehaviour
{
    public void AnaMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitSonMenu()
    {
        Application.Quit();
    }
}
