using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameManager gameManager;
    //private Animator playerAnimator;

    [SerializeField] private float speed = 5.0f;
    //[SerializeField] private float jumpForce = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        DestroyPlayerOutOfBound();
    }

    private void DestroyPlayerOutOfBound()
    {
        if (gameObject.transform.position.y < -3.5)
        {
            Destroy(gameObject);
            gameManager.GameOver();
        }
    }
}
