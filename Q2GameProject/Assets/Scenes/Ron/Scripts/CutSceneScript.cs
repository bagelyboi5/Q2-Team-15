using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneScript : MonoBehaviour
{
    public void Start()
    {
        Invoke("Scene1", 3);
    }
    public void Scene1()
    {
        gameObject.SetActive(true);
        Invoke("Scene2", 3);
    }
    public void Scene2()
    {
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        Invoke("Scene3", 3);
    }
    public void Scene3()
    {
        gameObject.SetActive(true);
        gameObject.SetActive(false);
        Invoke("Level1", 3);
    }
}
