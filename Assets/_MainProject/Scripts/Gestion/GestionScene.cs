using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{


    public void ChangerJeu
        ()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // R�cup�re l'index de la sc�ne en cours
        SceneManager.LoadScene(1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }


}
