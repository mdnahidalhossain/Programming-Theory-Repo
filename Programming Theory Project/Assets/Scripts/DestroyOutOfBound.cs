using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float xBound = 22.0f;

    // Update is called once per frame
    void Update()
    {
        DestroyTile();
    }

    private void DestroyTile()
    {
        if (transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
    }
}
