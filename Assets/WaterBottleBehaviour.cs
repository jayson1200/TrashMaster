using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottleBehaviour : MonoBehaviour
{
    public float deathTimer = 10;

    public Rigidbody2D waterBottle;

    // Start is called before the first frame update
    void Start()
    {
        waterBottle = this.gameObject.GetComponent<Rigidbody2D>();

        waterBottle.AddTorque(Random.Range(-2,2)*50, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        deathTimer -= 1 * Time.deltaTime;

        if (deathTimer < 0)
        {
            GameObject.Destroy(gameObject);
        }

        
    }

    private void OnMouseDown()
    {
        DestroyObject(gameObject);
        HitManager.score += 100;
    }
}
