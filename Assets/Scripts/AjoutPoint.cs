using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AjoutPoint : MonoBehaviour
{
    [SerializeField] GameObject joueur;
    [SerializeField] TMP_Text pointage;
    int nbr;
    GameObject joueurDuplique;
    bouge b;
    private void Awake()
    {
        b = joueur.GetComponent<bouge>();
        GameObject joueurDuplique = new GameObject();
        nbr = 0;
        pointage.text = $"Points: {nbr}";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            Debug.Log("player entered");
            joueurDuplique = GameObject.Instantiate(joueur);
            Destroy(joueurDuplique.GetComponent<bouge>());
            nbr++;
            pointage.text = $"Points: {nbr}";

            b.repositionner();
        }
    }


}
