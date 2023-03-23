using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    // Attributs

    private GameManager _gestionJeu;
    private bool _touche;


    private void Start()
    {
        _gestionJeu= FindObjectOfType<GameManager>();
        _touche= false;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                //gameObject.GetComponent<Rigidbody>().useGravity=false;
                _gestionJeu.AugmenterPointage();
                _touche = true;
                StartCoroutine(Wait4());

            }


        }


    }
    IEnumerator Wait4()    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);

        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        _touche = false;
    }

}
