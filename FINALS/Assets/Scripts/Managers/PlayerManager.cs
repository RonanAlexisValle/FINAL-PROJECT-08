using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerManager : MonoBehaviour
{
    public static bool gameover;
    public GameObject gameOverPanel;

    public static bool isGameStarted;

    public static int numberofcoins;
    public TMP_Text DisplayScore;

    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
        numberofcoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            Time.timeScale = 2;
            gameOverPanel.SetActive(true);
        }
        DisplayScore.text = "Score:" + numberofcoins;
    }
}
