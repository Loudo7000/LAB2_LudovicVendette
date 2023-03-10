using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs
    private int _pointage;
    private int _accrochageNiveau1 = 0;
    private float _tempsNiveau1 = 0.0f;



    // Méthodes privées

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GameManager>().Length;
        if(nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        InstructionDepart();
        Pointage= 0;
    }

    private void Update()
    {
        
    }

    private static void InstructionDepart()
    {
        Debug.Log("*** Course à obtacles ***");
        Debug.Log("*** Le but du jeu est d'atteindre la zone d'arrivée le plus rapidement possible ***");
        Debug.Log("*** Chaque contact avec un obtacle entrainera un pénalité ***");
    }

    // Méthodes public
    public void AugmenterPointage()
    {
        Pointage++;
    }

    public int Pointage { get => _pointage; set => _pointage = value; }
    public int AccrochageNiveau1 { get => _accrochageNiveau1; set => _accrochageNiveau1 = value; }
    public float TempsNiveau1 { get => _tempsNiveau1; set => _tempsNiveau1 = value; }
}
