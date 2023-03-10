using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Attributs

    private bool _capFinish;
    private GameManager _gestionJeu;
    private Player _player;


    // Méthodes privées



    private void Start()
    {
        _capFinish = false;
        _gestionJeu = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (_capFinish)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_capFinish)
        {

            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            _capFinish = false;

            int noScene = SceneManager.GetActiveScene().buildIndex;

            switch (noScene)
            {
                case 0:
                    {
                        _gestionJeu.SetNiveau1(_gestionJeu.Pointage, Time.time);
                        SceneManager.LoadScene(noScene + 1);

                    }
                    break;
                case 1:
                    {
                        _gestionJeu.SetNiveau2(_gestionJeu.Pointage, Time.time);
                        SceneManager.LoadScene(noScene + 1);
                    }
                break;
                case 2:
                    {
                        Debug.Log("*** Fin de la partie ***");


                        Debug.Log("*** Niveau 1 ***");
                        Debug.Log($"{_gestionJeu.TempsNiveau1} Secondes se sont écoulées");
                        Debug.Log($"Nombre d'accrochages {_gestionJeu.AccrochageNiveau1}");

                        Debug.Log("*** Niveau 2 ***");
                        Debug.Log($"{_gestionJeu.TempsNiveau2} Secondes se sont écoulées");
                        Debug.Log($"Nombre d'accrochages {_gestionJeu.AccrochageNiveau2}");

                        Debug.Log("*** Niveau 3 ***");
                        Debug.Log($"{Time.time} Secondes se sont écoulées");
                        Debug.Log($"Nombre d'accrochages {_gestionJeu.Pointage}");
                        Debug.Log($"{Time.time + _gestionJeu.Pointage} Pts");

                        _player.finPartieJoueur();
                    }
                    break;
            }

        }


    }
}
