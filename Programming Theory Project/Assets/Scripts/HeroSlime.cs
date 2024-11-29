using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSlime : PlayerController
{
    private Transform movingTile;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tile"))
        {
            movingTile = collision.gameObject.transform;
            gameObject.transform.SetParent(movingTile);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            Destroy(other.gameObject);
        }
    }
    
}
