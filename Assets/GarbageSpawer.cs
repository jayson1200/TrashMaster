using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawer : MonoBehaviour
{
    public GameObject garbage;
    public float garbageThrowSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeGarbage", 3, garbageThrowSpeed);
        InvokeRepeating("increaseGarbageSpeed", 5, 5);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeGarbage()
    {
        Instantiate(garbage, new Vector3(Random.Range(-7.6f, 7.6f), this.gameObject.transform.position.y, 0), Quaternion.identity);
    }

    public void increaseGarbageSpeed()
    {
        garbageThrowSpeed = garbageThrowSpeed * 0.7f;
    }

}
