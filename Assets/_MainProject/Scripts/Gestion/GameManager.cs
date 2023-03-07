using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs
    private int _pointage;

    public int Pointage { get => _pointage; set => _pointage = value; }

    // M�thodes priv�es

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
        Debug.Log("*** Course � obtacles ***");
        Debug.Log("*** Le but du jeu est d'atteindre la zone d'arriv�e le plus rapidement possible ***");
        Debug.Log("*** Chaque contact avec un obtacle entrainera un p�nalit� ***");
    }

    // M�thodes public
    public void AugmenterPointage()
    {
        Pointage++;
    }

}
