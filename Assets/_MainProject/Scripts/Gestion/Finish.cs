using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Attributs

    private GameManager _gestionJeu;



    // Méthodes privées



    private void Start()
    {
        _gestionJeu = FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")  // Si la collision est produite avec le joueur et la partie n'est pas terminée
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;  // on change la couleur du matériel à vert
            int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
            if (noScene == (SceneManager.sceneCountInBuildSettings - 2))  // Si nous somme sur le dernier niveau de jeu
            {
                _gestionJeu.SetTempsFinal(Time.time);
                SceneManager.LoadScene(noScene + 1);
            }
            else
            {
                // Appelle la méthode publique dans gestion jeu pour conserver les informations du niveau 1
                //_gestionJeu.SetNiveau1(_gestionJeu.GetPointage(), Time.time);
                // Charge la scène suivante
                SceneManager.LoadScene(noScene + 1);
            }
        }


    }
}
