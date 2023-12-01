using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Debug.Log("Grounded!");
            gameObject.GetComponentInParent<PlayerMovement>().canJump = true;
        }
    }
}
