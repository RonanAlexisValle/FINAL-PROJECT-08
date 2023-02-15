using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }
    public void  HellMode()
    {
        SceneManager.LoadScene("Cameo into the Jungle");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void QuitGame()
    {
    #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
 
    #else
        Application.Quit();
        Debug.Log("QUIT");
    #endif

    }

}
