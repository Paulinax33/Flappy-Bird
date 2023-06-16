using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioClip effect;
    private void OnCollisionEnter2D(Collision2D other)
    {

        //Debug.Log("OnCollisionEnter2D");
            AudioSource.PlayClipAtPoint(effect, transform.position);
        
    }
}
