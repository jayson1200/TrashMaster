using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishObject : MonoBehaviour
{
    public Sprite fishSpriteColor;
    public float fishSpeed;
 
    
    public float deathTimer = 10;

    public float firstXPosition;

    public FishObject(float FISHSPEED, Sprite FISHSPRITECOLOR)
    {
        fishSpeed = FISHSPEED;
        fishSpriteColor = FISHSPRITECOLOR;
    }

    // Start is called before the first frame update
    void Start()
    {
        firstXPosition = this.gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        deathTimer -= 1 * Time.deltaTime;

        if(deathTimer < 0)
        {
            GameObject.Destroy(this);
        }

        if(firstXPosition > 0)
        {
            this.gameObject.transform.Translate(-1, 0, 0);
        }
        else if(firstXPosition < 0)
        {
            this.gameObject.transform.Translate(1, 0, 0);
        }
    }
}
