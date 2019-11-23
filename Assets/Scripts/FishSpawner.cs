using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{

    public Sprite[] difFishes;

    public int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        createNewFish(randomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = (int)Mathf.Round(Random.Range(0f, 4.4f));

    }

    public void createNewFish(int fishColorNumber)
    {
        Sprite spriteToFish = null;

        float fishYLocation = Random.Range(2, 4);

        if (fishColorNumber == 0)
        {
            spriteToFish = difFishes[0];
        }
        else if(fishColorNumber == 1)
        {
            spriteToFish = difFishes[1];
        }
        else if(fishColorNumber == 2)
        {
            spriteToFish = difFishes[3];
        }

        FishObject oneFish = new FishObject(Random.Range(10, 25),spriteToFish);

        Instantiate(oneFish);
    }
}