using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
        transform.position = new Vector3(player.transform.position.x, Mathf.Clamp(player.transform.position.y, 0, 8) , -30);
    }
}
