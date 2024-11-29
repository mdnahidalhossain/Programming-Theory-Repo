using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : SlideLeft
{
    private float posX = 12.5f;
    private float speed = 5.0f;
    private float direction = 1.0f;
    //private float posX2 = -12.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    public override void MoveLeft()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        // Reverse direction if the tile reaches the bounds
        if (transform.position.x > posX)
        {
            direction = -1; // Move left
        }
        else if (transform.position.x < -posX)
        {
            direction = 1; // Move right
        }
    }
}
