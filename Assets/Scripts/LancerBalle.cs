using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancerBalle : MonoBehaviour
{
    [SerializeField] GameObject joueur;
    [SerializeField] float force;
    [SerializeField] float hauteur;
    [SerializeField] float distance;
    Vector3 v3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            v3 = new Vector3(0, hauteur, distance);
            joueur.GetComponent<Rigidbody>().AddForce(v3 * force * Time.fixedDeltaTime);
        }
    }
}
