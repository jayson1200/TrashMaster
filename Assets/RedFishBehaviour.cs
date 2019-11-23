using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFishBehaviour : MonoBehaviour
{

    public float deathTimer = 10;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deathTimer -= 1 * Time.deltaTime;

        if (deathTimer < 0)
        {
            GameObject.Destroy(gameObject);
        }

        this.gameObject.transform.Translate(5*Time.deltaTime, 0, 0);
    }
}
