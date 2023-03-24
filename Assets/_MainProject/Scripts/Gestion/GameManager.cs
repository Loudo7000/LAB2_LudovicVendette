using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs
    private int _pointage;
    private int _accrochageNiveau1 = 0;
    private float _tempsNiveau1 = 0.0f;
    private int _accrochageNiveau2 = 0;
    private float _tempsNiveau2 = 0.0f;
    private int _accrochageNiveau3 = 0;
    private float _tempsNiveau3 = 0.0f;



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
        Pointage = 0;
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

    public void SetNiveau1(int accrochages, float tempsNiv1)
    {
        _accrochageNiveau1 = accrochages;
        _tempsNiveau1 = tempsNiv1;
    }

    public void SetNiveau2(int accrochages, float tempsNiv2)
    {
        _accrochageNiveau2 = accrochages;
        _tempsNiveau2 = tempsNiv2;
    }

    public int Pointage { get => _pointage; set => _pointage = value; }
    public int AccrochageNiveau1 { get => _accrochageNiveau1; set => _accrochageNiveau1 = value; }
    public float TempsNiveau1 { get => _tempsNiveau1; set => _tempsNiveau1 = value; }
    public int AccrochageNiveau2 { get => _accrochageNiveau2; set => _accrochageNiveau2 = value; }
    public float TempsNiveau2 { get => _tempsNiveau2; set => _tempsNiveau2 = value; }
    public int AccrochageNiveau3 { get => _accrochageNiveau3; set => _accrochageNiveau3 = value; }
    public float TempsNiveau3 { get => _tempsNiveau3; set => _tempsNiveau3 = value; }
}
