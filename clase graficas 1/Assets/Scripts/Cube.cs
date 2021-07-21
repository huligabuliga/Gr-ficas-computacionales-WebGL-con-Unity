using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float moveSpeed;
    public float vel_rot;
    public float jumpheight;
    private Rigidbody rd;


    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical")* Time.deltaTime);

        

        if (Input.GetKey(KeyCode.Space))
        {
            rd.AddForce(transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.R))
        {
            rd.AddForce(Vector3.up * jumpheight);
        }

            gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * vel_rot, 0);
    }
}
