using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNew : MonoBehaviour
{
    public GameObject[] fishes = new GameObject[4];
    private int selectedFish = -1;
    public Transform finishLine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < fishes.Length; i++)
        {
            if (fishes[i].transform.position == finishLine.position)
            {

                // Allow the player to select a different fish to move
                if (Input.GetMouseButtonDown(0))
                {
                    selectedFish = i;
                }

                if (selectedFish != -1)
                {
                    fishes[selectedFish].transform.position += new Vector3(-2, 0, 0);
                }
            }

        }
    }
}
