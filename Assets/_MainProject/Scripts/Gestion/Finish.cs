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
            if (noScene == 1)
            {
                _player.finPartieJoueur();
                Debug.Log("*** Fin de la partie ***");
                Debug.Log($"{Time.time} Secondes se sont écoulées");
                Debug.Log($"Nombre d'accrochages {_gestionJeu.Pointage}");
                Debug.Log($"{Time.time + _gestionJeu.Pointage} Pts");
            }
            else
            {
                SceneManager.LoadScene(noScene + 1);

            }

        }


    }
}
