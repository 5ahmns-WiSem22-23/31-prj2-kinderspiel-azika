using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CollisionTester : MonoBehaviour
{
    public GameObject Fish;
    public SpriteRenderer Renderer;
    public bool isDestroyed = false;
    public AudioSource playsound;
    public AudioSource FishLaugh;
    

    

    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
    }

    IEnumerator PlayPauseCoroutinezwei(float delay)
    {
        FishLaugh.Play();
        yield return new WaitForSeconds(delay);
        FishLaugh.Stop();

    }
    IEnumerator PlayPauseCoroutine(float delay)
    {
            playsound.Play();
            yield return new WaitForSeconds(delay);
            playsound.Stop();
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FinishLine>())
        {
            FishLaugh.Play();
            StartCoroutine(PlayPauseCoroutinezwei(3));
            Debug.Log("it works");
            isDestroyed = true;
            Fish.SetActive(false);
        }
         
        if (collision.GetComponent<Schiff>())
        {
            playsound.Play();
            StartCoroutine(PlayPauseCoroutine(3));
            Debug.Log("he dead");
            isDestroyed = true;
            Fish.SetActive(false);

        }
    }

}