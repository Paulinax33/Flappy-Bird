using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public GameObject coin;
    private void OnTriggerExit2D(Collider2D other)
    {
        GameManager.Instance.UpdateScore();
        if(other.tag == "Player")
        {
            Destroy(coin);
        }
        GameManager.Instance.UpdateScore2();
    }
    
}
