using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _velocity = 500f;
    [SerializeField] private float _force = 300f;
    private Rigidbody _rb;

    // Méthodes privées
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementJoueur();

    }

    private void MouvementJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        direction.Normalize();
        //transform.Translate(direction * Time.deltaTime * _vitesse);
        if (SceneManager.GetActiveScene().buildIndex == 2) 
            _rb.AddForce(direction * Time.fixedDeltaTime * _force);
        else
            _rb.velocity = direction * Time.fixedDeltaTime * _velocity;

    }

    public void finPartieJoueur()
    {
        gameObject.SetActive(false);
        //_vitesse= 0;
    }

}
 