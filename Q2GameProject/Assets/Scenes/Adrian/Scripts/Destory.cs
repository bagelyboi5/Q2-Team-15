using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{

    public bool yes;
    private void Start()
    {
        yes = true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (yes == true) {
            if (collision.gameObject.tag == "Player")
                Destroy(collision.gameObject);
        }
        
    }
}