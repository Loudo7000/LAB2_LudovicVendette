using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 500f;
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
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);

    }

    public void finPartieJoueur()
    {
        gameObject.SetActive(false);
        //_vitesse= 0;
    }

}
 