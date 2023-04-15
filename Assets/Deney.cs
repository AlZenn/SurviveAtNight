using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deney : MonoBehaviour
{
    /*
    private void OnMouseDown()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            GameObject clickedObject = gameObject; 
            if (clickedObject.CompareTag("enemy")) 
            {
                Destroy(clickedObject);
            }
        }
    }
        */

    public AudioSource clicksound;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit))
            {
                /*
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                   
                    Destroy(bc.gameObject);
                }
                */
                if (hit.collider.CompareTag("enemy"))
                {
                    clicksound.Play();
                    Destroy(hit.collider.gameObject);
                }

            }

        }
            
    }
}
