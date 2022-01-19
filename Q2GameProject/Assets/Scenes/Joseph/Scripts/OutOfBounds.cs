using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject Beaninventory;

    private void Start()
    {
        GetComponent<BeanScriptforinventory>();
    }
    public  void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = spawnpoint.transform.position;
        BeanScriptforinventory.BeanCount = 0;
    }


}