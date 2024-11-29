using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideLeft : MonoBehaviour
{
    [SerializeField] protected float tileSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTile();
    }

    public virtual void MoveTile()
    {
        transform.Translate(Vector3.left * tileSpeed * Time.deltaTime);
    }
}
