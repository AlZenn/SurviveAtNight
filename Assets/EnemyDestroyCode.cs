using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyCode : MonoBehaviour
{
    //GameManager gameManager;
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    */
    public AudioSource cenevarSesi;
    public GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {

            gameManager.loseHealth();
            cenevarSesi.Play();
            Destroy(other.gameObject);
        }
    }
}
