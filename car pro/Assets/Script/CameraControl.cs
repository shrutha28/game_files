using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -16);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+offset;
    }
}
