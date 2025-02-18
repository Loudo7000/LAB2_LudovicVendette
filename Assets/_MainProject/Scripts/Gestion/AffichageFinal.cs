using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AffichageFinal : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtAccorchagesTotal = default;
    [SerializeField] private TMP_Text _txtPointageTotal = default;
    private GameManager _gestionJeu;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GameManager>();
        _txtTempsTotal.text = "Temps Total : " + _gestionJeu.TempsFinal.ToString("f2") + " sec.";
        _txtAccorchagesTotal.text = "Nombres d'accrochages : " + _gestionJeu.Pointage.ToString();
        float pointageTotal = _gestionJeu.TempsFinal + _gestionJeu.Pointage;
        _txtPointageTotal.text = "Pointage Final : " + pointageTotal.ToString("f2") + " sec.";
    }
}
