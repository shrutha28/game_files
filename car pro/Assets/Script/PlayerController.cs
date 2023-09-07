using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed=45.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward*Time.deltaTime*speed);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horizontalInput);
        transform.Rotate(Vector3.up,speed * horizontalInput*Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed*forwardInput);
    }
}
