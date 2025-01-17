using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife1 : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public bool attachedToWood;


    private void OnTriggerEnter2D(Collider2D col) 
    {
    if (col.gameObject.tag == "Wood")
        {
            rigidbody.velocity = Vector2.zero;
            transform.parent = col.transform;
            attachedToWood = true;
        }

    if(col.gameObject.tag == "Knife")
        {
            if (col.gameObject.GetComponent<Knife1>().attachedToWood == true)
            
            {
                rigidbody.velocity = Vector2.zero;
                rigidbody.gravityScale = 1;
                Debug.LogError("Game over !!!");
            }

        }

    if (col.gameObject.tag == "Apple") 
        {
            Destroy(col.gameObject);
        }

    }
    
}
