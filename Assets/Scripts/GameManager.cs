using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject menus;
    public GameObject spawner;

    public int life = 3;
    public GameObject kalp1;
    public GameObject kalp2;
    public GameObject kalp3;

    // Update is called once per frame
    void Update()
    {
        if (life == 2)
        {
            kalp1.GetComponent<Image>().color = Color.black;
        }
        if (life == 1)
        {
            kalp2.GetComponent<Image>().color = Color.black;
        }
        if (life == 0)
        {
            kalp3.GetComponent<Image>().color = Color.black;

            menus.SetActive(true);
            spawner.SetActive(false);

            Debug.Log("Oyun Bitti");
        }

    }

    public void loseHealth()
    {
        life--;
        Debug.Log(life);
    }

}
