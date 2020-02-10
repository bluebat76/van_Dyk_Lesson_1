using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Vspeed;
    public float Hspeed;
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * Vspeed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * Hspeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * Hspeed * horizontalInput);
    }
}
