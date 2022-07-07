using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoebaController : MonoBehaviour
{

    public float speed = 5f;
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");

        Vector3 newPos = new Vector3(horizontalInput, 0, VerticalInput);
        newPos.Normalize();

        transform.Translate(newPos * speed * Time.deltaTime, Space.World);

        if(newPos != Vector3.zero)
        {

            Quaternion toRotation = Quaternion.LookRotation(newPos, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

        }
    }
}
