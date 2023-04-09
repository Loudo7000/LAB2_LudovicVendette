using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _menuPause = default;
    [SerializeField] private GameObject _player;
    private Vector3 _playerPos;
    private bool _enPause;
    private bool _ajust = true;
    private GameManager _gestionJeu;


    void Start()
    {
        _gestionJeu = FindObjectOfType<GameManager>();
        _txtAccrochages.text = "Accrochages : " + _gestionJeu.Pointage;
        AfficheTemps();
        _enPause = false;
        _playerPos = GameObject.FindGameObjectWithTag("Player").transform.position; ;
    }


    private void Update()
    {
        GestionTempsStart();
        GestionPause();
    }

    private void GestionTempsStart()
    {
        if (_playerPos != _player.transform.position)
        {

            if (_ajust)
            {
                _gestionJeu.TempsAjust += Time.timeSinceLevelLoad;
                _ajust = false;
            }
            AfficheTemps();
        }

    }

    private void AfficheTemps()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1 && _ajust)
        {
            _txtTemps.text = "Temps : 0,00";

        }
        else
        {
            float temps = Time.time - _gestionJeu.TempsDepart;
            _txtTemps.text = "Temps : " + (temps - _gestionJeu.TempsAjust).ToString("f2");

        }

    }

    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
    }



    public void ChangerPointage(int p_pointage)
    {
        _txtAccrochages.text = "Accrochages : " + p_pointage.ToString();
    }

    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }
}
