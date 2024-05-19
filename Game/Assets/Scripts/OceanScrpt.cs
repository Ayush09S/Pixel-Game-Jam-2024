using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanScrpt : MonoBehaviour
{
    public CircleCollider2D playerCollider;
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        controller.isInOcean = collision.Equals(playerCollider);
        Debug.Log("Happens");
    }

}
