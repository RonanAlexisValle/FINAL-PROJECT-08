using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour

{
    private GameObject player;
    public PlayerController playerControllerScript;
    private Rigidbody animalRB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        //move the enemy towards the players position
        animalRB.AddForce(lookDirection * speed);

        if (playerControllerScript.gameOver == true)
        {
            speed = 0;

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Rigidbody animalRB= collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromObstacle = collision.gameObject.transform.position - transform.position;

            animalRB.AddForce(awayFromObstacle * 6, ForceMode.Impulse);

  
        }
        
    }
}