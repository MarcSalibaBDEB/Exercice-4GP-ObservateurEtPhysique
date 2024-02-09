using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    public class Sujet
    {
        //public event Action OnEvenement;
        private void Truc()
        {
            //OnEvenement();
        }
    }
    public class Observateur
    {
        Sujet sujet;
        public Observateur()
        {
            sujet = new Sujet();
            //sujet.OnEvenement += FaireLeTruc;
        }
        public void FaireLeTruc()
        {
            // Méthode appelée quand l'événement se produit
        }
    }
}
