using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasi : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void onClick()
    {
      dragging = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }

    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque (Vector3.down * x);
            rb.AddTorque (Vector3.down * y);
        }
    }
}
