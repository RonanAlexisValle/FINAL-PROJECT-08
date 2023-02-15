using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public PlayerManager PlayerManager;
    public float speed = 1.0f;
    private PlayerController playerControllerScript;



    // Use t$$anonymous$$s for initialization
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, 0);

            if (PlayerManager.numberofcoins != 0)
            {
                speed += .009f;
             
            }

            float change = speed * Time.deltaTime;
            transform.Translate(change * Time.deltaTime, 0, 0, 0);
        }

        if (playerControllerScript.gameOver == true)
        {
            speed = 0;

        }
    }
}
