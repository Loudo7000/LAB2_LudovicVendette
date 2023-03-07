using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{

    // Attributs

    private bool _ZoneAct= false;
    [SerializeField] private List<GameObject> _listPieges= new List<GameObject>();
    private List<Rigidbody>  _listeRb =new List<Rigidbody>();
    [SerializeField] private float _intensiteForce = 50;
    

    private void Start()
    {
        foreach(var piege in _listPieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }
        //_rb= _piege.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_ZoneAct)
        {
            foreach(var rb in _listeRb) 
            {
                rb.useGravity = true;
                Vector3 direction = new Vector3(0f, -1f, 0f);
                rb.AddForce(direction * _intensiteForce);
            }
            _ZoneAct = true;
        }
    }
}
