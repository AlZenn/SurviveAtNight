using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public AudioSource doorOpenSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Animator animator = GetComponent<Animator>();
            animator.Play("OpenDoor");
            doorOpenSound.Play();
        }

    }
}
