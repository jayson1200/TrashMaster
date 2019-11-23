using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempFishSpawner : MonoBehaviour
{
    public GameObject redFish;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeFish", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeFish()
    {
        Instantiate(redFish, new Vector3(this.gameObject.transform.position.x, Random.Range(-2, 3.5f), 0), Quaternion.identity);
    }
}
