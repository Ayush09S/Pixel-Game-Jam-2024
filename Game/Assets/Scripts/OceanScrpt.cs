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

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            controller.isInOcean = true;
            Debug.Log("Happens");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            controller.isInOcean = false;
        }
    }
}
