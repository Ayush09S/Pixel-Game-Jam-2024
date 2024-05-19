using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    public float jump;
    public float rbG;
    public float drown;
    public bool isGrounded = false;
    public bool isInOcean = false;
    public CircleCollider2D playerCollider;

    private float moveX;
    private float moveY;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        rbG = rb.gravityScale; // Allow visibility of gravity scale in editor
        
        rb.velocity = new Vector2(speed * Time.deltaTime * moveX, rb.velocity.y); // Allow Horizontal Movement

        if (isInOcean == true)
        {
            rb.gravityScale = 0;

            rb.AddForce(Vector2.down * drown * Time.deltaTime, ForceMode2D.Force); // Make the player slowly go downwards
            rb.velocity = new Vector2(speed * Time.deltaTime * moveX, speed * Time.deltaTime * moveY); // Allow Vertical movement
        }
        if (isInOcean == false)
        {
            rb.gravityScale = 2;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // Dive function (Yet to be decided how to implement (Auto-animated dive; Player simply jumps))
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            Debug.Log("Player has diven");
        }
    }
}
