using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public float force = 100;
    public float maxForce = 200;
    public float minForce = 25;

    private Vector3 direction;

    public Rigidbody rb;
    private float forceChangeAmount = 25;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (Vector3)(mouse - transform.position);

        if (Input.GetMouseButtonDown(0) && rb.velocity == Vector3.zero)
        {
            rb.AddForce(direction);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && force < maxForce)
        {
            force += forceChangeAmount;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && force > minForce)
        {
            force -= forceChangeAmount;
        }
    }
}
