using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holding : MonoBehaviour
{
    float moveForce = 1.0f;
    float rotateTorque = 1.0f;
    float hoverHeight = 4.0f;
    float hoverForce = 5.0f;
    float hoverDamp = 0.5f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 0.5f;
        rb.angularDrag = 0.5f;
    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown("E"))
        { 
        rb.AddForce(Input.GetAxis("Vertical") * moveForce * transform.forward);
        rb.AddTorque(Input.GetAxis("Horizontal") * rotateTorque * Vector3.up);

        RaycastHit hit;
        Ray downRay = new Ray(transform.position, -Vector3.up);

            if (Physics.Raycast(downRay, out hit))
            {
                // The "error" in height is the difference between the desired height
                // and the height measured by the raycast distance.
                float hoverError = hoverHeight - hit.distance;

                // Only apply a lifting force if the object is too low (ie, let
                // gravity pull it downward if it is too high).
                if (hoverError > 0)
                {
                    // Subtract the damping from the lifting force and apply it to
                    // the rigidbody.
                    float upwardSpeed = rb.velocity.y;
                    float lift = hoverError * hoverForce - upwardSpeed * hoverDamp;
                    rb.AddForce(lift * Vector3.up);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {

        }
    }
}
