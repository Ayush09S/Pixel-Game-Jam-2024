using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            controller.isGrounded = true;
            Debug.Log("IsGrounded =  True");
        }
        if (collision.CompareTag("Sky"))
        {
            controller.isGrounded = false;
            Debug.Log("IsGrounded = False (Sky)");
        }
        if (collision.CompareTag("Ocean"))
        {
            controller.isGrounded = false;
            Debug.Log("IsGrounded = False (Ocean)");
        }
    }
}
