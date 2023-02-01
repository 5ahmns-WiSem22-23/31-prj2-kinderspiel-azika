using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneHehe : MonoBehaviour
{
    public void Pirate()
    {
        GetComponent<AudioSource>().Play();
    }
    public void touch_button()
    {
        GetComponent<Animation>().Play("ButtonAnimation");
    }

    public void OpenScene()
    {
        
        SceneManager.LoadScene("GameScene");
    }

}
