using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouge : MonoBehaviour
{
    [SerializeField] float speed = 1;
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
        v3 = new Vector3(h, 0, v);
        rb.velocity = new Vector3(h * speed, rb.velocity.y, v * speed);
        rb.AddForce(v3 * force * Time.fixedDeltaTime);
          
    }
}
