using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class BeanSave : MonoBehaviour
{
    public int BEERN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BEERN = GetComponent<BeanScriptforinventory>().beansspawned;
    }
}
