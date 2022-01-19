using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clamp : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY), 0f);
    }
}
