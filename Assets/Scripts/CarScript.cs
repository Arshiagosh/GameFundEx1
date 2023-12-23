using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed*Time.deltaTime,0f,0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed*Time.deltaTime,0f,0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0f,rotationSpeed*Time.deltaTime,0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0f,-rotationSpeed*Time.deltaTime,0f);
        }
    }
}
