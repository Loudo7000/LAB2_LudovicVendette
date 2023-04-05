using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Attributs
    private int _pointage;
    private float _tempsDepart = 0;
    private float _tempsFinal = 0;



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
        _tempsDepart = Time.time;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    // Méthodes public
    public void AugmenterPointage()
    {
        Pointage++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ChangerPointage(_pointage);
    }

    public void SetTempsFinal(float p_tempFinal)
    {
        _tempsFinal = p_tempFinal - _tempsDepart;
    }


    public int Pointage { get => _pointage; set => _pointage = value; }
    public float TempsDepart { get => _tempsDepart; set => _tempsDepart = value; }
    public float TempsFinal { get => _tempsFinal; set => _tempsFinal = value; }
}
