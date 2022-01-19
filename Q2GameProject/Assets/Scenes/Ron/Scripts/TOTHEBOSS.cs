using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TOTHEBOSS : MonoBehaviour
{
    public string YouNameHere;
    public int Beancount2;
    public GameObject Effetr;
    public GameObject Inevtorystuff;


    public void Update()
    {

        Beancount2 = Inevtorystuff.GetComponent<BeanScriptforinventory>().beansspawned;
        if (Beancount2 >= 5)
        {
            Effetr.SetActive(true);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (Beancount2 > 5)
        {
            SceneManager.LoadScene(YouNameHere);
        }
    }
}
