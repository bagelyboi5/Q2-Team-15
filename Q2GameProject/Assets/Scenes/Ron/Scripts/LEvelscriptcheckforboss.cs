using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEvelscriptcheckforboss : MonoBehaviour
{
    public string YouNameHere;
    public int Beancount2;
    public GameObject effectactive;


    public void Update()
    {
        Beancount2 = GetComponent<BeanScriptforinventory>().beansspawned;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (Beancount2 >= 5)
        {
            SceneManager.LoadScene(YouNameHere);
            effectactive.SetActive(true);
        }
    }
}
