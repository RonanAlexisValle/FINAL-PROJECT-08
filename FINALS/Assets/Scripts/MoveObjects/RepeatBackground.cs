using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float x;
    public float speed;
    private Vector3 startPos;
    private float repeatWidth;
       private PlayerController playerControllerScript;



    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        startPos = transform.position;
        repeatWidth = 130;
    }

    // Update is called once per frame
    void Update()
    {

        if (playerControllerScript.gameOver == false )
        {
            x = transform.position.x;
            x += speed * Time.deltaTime;
            transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

        if (-transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }

        if (playerControllerScript.gameOver == true)
        {
            speed = 0;

        }
    }
}
