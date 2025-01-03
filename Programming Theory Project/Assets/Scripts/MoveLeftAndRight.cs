using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : SlideLeft
{
    private float posX = 12.5f;
    private float direction = 1.0f;

    // Update is called once per frame
    void Update()
    {
        MoveTile();
    }

    public override void MoveTile()
    {
        transform.Translate(Vector3.right * tileSpeed * direction * Time.deltaTime);

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
