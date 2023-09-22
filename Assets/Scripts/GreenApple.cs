using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GreenApple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
        if( collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Basket") {
            Destroy(this.gameObject);
            if(collision.gameObject.tag == "Basket") {
                ScoreTracker.numOfLives--;
                
            }
        }
    }
}
