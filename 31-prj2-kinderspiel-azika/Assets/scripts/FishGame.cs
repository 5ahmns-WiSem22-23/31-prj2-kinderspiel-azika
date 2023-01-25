using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGame : MonoBehaviour
{
    public GameObject ship; // Drag and drop the ship object in the inspector
    public GameObject[] fish; // Drag and drop the fish objects in the inspector
    public Transform finishLine; // Drag and drop the finish line object in the inspector

     // keeps track of the selected fish

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public bool NothingHappens = false;
    // Start is called before the first frame update
    void Start()
    {
        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");

    }

    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {

        int randomDiceSide = 0;
        int finalSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        finalSide = randomDiceSide + 1;

        Debug.Log(finalSide);

        if (finalSide == 1)
        {
            ship.transform.position += new Vector3(-1, 0, 0);
        }

        if (finalSide == 2)
        {
            ship.transform.position += new Vector3(-1, 0, 0);
        }

        switch (finalSide)
        {
            case 3:
                MoveFish(fish[0]);
                break;
            case 4:
                MoveFish(fish[1]);
                break;
            case 5:
                MoveFish(fish[2]);
                break;
            case 6:
                MoveFish(fish[3]);
                break;
        }

    

     

        
    }
    void MoveFish(GameObject fish)
    {
         if (!GameObject.FindGameObjectWithTag("fish").GetComponent<CollisionTester>().isDestroyed)
            {
            fish.transform.position += new Vector3(-2, 0, 0);
        }
        else
            {
            NothingHappens = true;
            }
 
        }
        
    }



            
