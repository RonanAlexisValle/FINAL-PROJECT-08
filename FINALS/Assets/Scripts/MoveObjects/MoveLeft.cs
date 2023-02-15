using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public float xBound = 100;

    private PlayerManager PlayerManager;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController> ();
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position.x > xBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);

        }
    }
}
