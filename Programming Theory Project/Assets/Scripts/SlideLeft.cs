using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideLeft : MonoBehaviour
{
    [SerializeField] private float tileSpeed = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    public virtual void MoveLeft()
    {
        transform.Translate(Vector3.left * tileSpeed * Time.deltaTime);
    }
}
