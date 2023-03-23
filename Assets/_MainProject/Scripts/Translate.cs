using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Translate : MonoBehaviour
{

    // Attributs
    [SerializeField] private float _vitesse = 10f;
    private Vector3 direction;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.x >= 20)
            direction = new Vector3(-1f, 0f, 0f);
        else if(transform.position.x <= -20)
            direction = new Vector3(1f, 0f, 0f);

        transform.Translate(direction * Time.fixedDeltaTime * _vitesse);

        
    }
}
