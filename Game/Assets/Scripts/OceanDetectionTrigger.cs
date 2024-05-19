using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanDetectionTrigger : MonoBehaviour
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
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            controller.isInOcean = true;
            Debug.Log("Player is in Ocean");
        }
    }
    */
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.transform.position.x > 0.9)
            {
                controller.isInOcean = true;
                Debug.Log("Player is on the right of the collider");
            }
            if (other.transform.position.x < 0.9)
            {
                controller.isInOcean = false;
                Debug.Log("Player is on the left of the collider");
            }
        }
    }
}
