using System.Collections;
using System.Collections.Generic;
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
    }

    private void FixedUpdate()
    {
        v3 = new Vector3(h, 0, v);
        rb.AddForce(v3 * force * Time.fixedDeltaTime);
    }
}
