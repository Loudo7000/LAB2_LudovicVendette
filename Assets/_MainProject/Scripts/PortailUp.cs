using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailUp : MonoBehaviour
{
    // Attributs
    private bool _ZoneAct = false;
    [SerializeField] private float _vitesse = 10f;
    [SerializeField] private GameObject _portail;
    private Vector3 direction = new Vector3(0f, 1f, 0f);


    void FixedUpdate()
    {


        if (_ZoneAct)
        {
            if (_portail.transform.position.y < 0)
            _portail.transform.Translate(direction * Time.fixedDeltaTime * _vitesse);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        _ZoneAct = true;
    }

}
