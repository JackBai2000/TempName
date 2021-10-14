using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextMap : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
            Debug.Log("Do something here");
        if (collision.gameObject.tag == "Player"){
            Debug.Log("does this also work");
        }
    }
    void FixedUpdate()
    {
        //..
        
    }
}
