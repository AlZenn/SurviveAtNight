using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationBitis : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obje"))
        {
            Animator animator = GetComponent<Animator>();
            animator.Play("endingPlayer");
        }

    }
}
