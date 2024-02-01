using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bouge : MonoBehaviour
{
    [SerializeField] float force = 100;
    Rigidbody rb;
    Vector3 v3;
    private float h;
    private float v;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (transform.position.y < -2)
        {
            repositionner();
        }
    }

    private void FixedUpdate()
    {
        v3 = new Vector3(h, 0, v);
        rb.AddForce(v3 * force * Time.fixedDeltaTime);
    }

    public void repositionner()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = new Vector3(0, 1, -10);
    }
}
