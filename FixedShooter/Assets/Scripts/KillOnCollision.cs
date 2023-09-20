using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if (collision.gameObject != null)
                GameManager.Instance.KillPlayer();
        }
    }
}
