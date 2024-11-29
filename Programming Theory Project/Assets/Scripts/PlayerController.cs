using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    //private Animator playerAnimator;

    [SerializeField] private float speed = 5.0f;
    //[SerializeField] private float jumpForce = 3.0f;

    [SerializeField] protected bool isOnGround = true;


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

        //if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        //{
        //    playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //    isOnGround = false;
        //    playerAnimator.SetTrigger("Jump");

        //}

        
    }
}
