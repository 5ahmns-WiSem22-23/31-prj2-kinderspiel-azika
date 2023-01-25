using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionTester : MonoBehaviour
{
    public GameObject Fish;
    public SpriteRenderer Renderer;
    public bool isDestroyed = false;

    

    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FinishLine>())
        {
           
            Debug.Log("it works");
            isDestroyed = true;
            Fish.SetActive(false);
        }

        if (collision.GetComponent<Schiff>())
        {
           
            Debug.Log("he dead");
            isDestroyed = true;
            Fish.SetActive(false);

        }
    }

}