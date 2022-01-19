using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject Beaninventory;
    public GameObject Player;
    public bool yes;
    public void Start()
    {
        yes = true;
        GetComponent<BeanScriptforinventory>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (yes == true)
        {
            Player.transform.position = spawnpoint.transform.position;
            BeanScriptforinventory.BeanCount = 0;
        }
    }




}