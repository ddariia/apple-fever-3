using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    
    
    {
        if (other.CompareTag("Knife")) 
        
        {

            AppleSplitter splitter = GetComponentInParent<AppleSplitter>();
            if (splitter != null) {

                splitter.SplitApple();
            }
        
        }
    
    
    
    }

}
