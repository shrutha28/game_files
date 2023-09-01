using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoller : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 rotateChange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ChangeColor());

        if (transform.localScale.x < 1.5){
            transform.localScale += scaleChange;
            transform.Rotate(rotateChange);
        }
        IEnumerator ChangeColor()
        {
            // Wait for 3 seconds
            yield return new WaitForSeconds(3);
            // Change the color to a different color, for example red
            GameObject.Find("Sphere").GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        }


    }

}
