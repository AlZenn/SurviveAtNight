using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 1f;
    private float hizArttir = 0.05f;
    void Start()
    {
        InvokeRepeating("increaseSpeed", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        if (speed >= 2f)
        {
            CancelInvoke("increaseSpeed");
        }

    }
    void increaseSpeed()
    {
        speed = speed + hizArttir;
        Debug.Log(speed);
    }

}
