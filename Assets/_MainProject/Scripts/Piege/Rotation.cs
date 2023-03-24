using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotation : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRot= 150f;
    private bool _ZoneAct = false;
    [SerializeField] private GameObject _Pieges;


    private void Start()
    {
        _Pieges.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_ZoneAct)
        {
            _Pieges.SetActive(true);
            _ZoneAct = true;
        }
    }

    void FixedUpdate()
    {
        RotationPiege();
    }

    private void RotationPiege()
    {
        if(_ZoneAct)
        {
            Vector3 direction = new Vector3(0f, 1f, 0f);
            _Pieges.transform.Rotate(direction * Time.fixedDeltaTime * _vitesseRot);
        }

    }
}
