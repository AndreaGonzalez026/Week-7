using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float speed = 10f; // Plane's speed
    [SerializeField] private float tiltSpeed = 30f; // Tilt speed

    // Update is called once per frame
    void Update()
    {
        // Move the plane forward at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Get the user's input for tilting the plane
        float verticalInput = Input.GetAxis("Vertical");

        // Tilt the plane up or down
        transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * tiltSpeed);
    }
}


