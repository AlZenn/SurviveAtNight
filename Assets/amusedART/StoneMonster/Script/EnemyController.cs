using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyController : MonoBehaviour
{
    public string playerTag = "Player";
    public float moveSpeed = 5f;
    private Transform playerTransform;
    private Rigidbody rb;
    
    //GameManager gameManager;

    void Start()
    {
        //gameManager = gameManager.GetComponent<GameManager>();
        playerTransform = GameObject.FindGameObjectWithTag(playerTag).transform;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(direction);
        rb.MovePosition(transform.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
    /*
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            //gameManager.loseHealth();
            Destroy(gameObject);
            
        }
    }
    */

}
