using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotation : MonoBehaviour
{

    [SerializeField] private float _vitesseRot= 50f;

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0f, 1f, 0f);
        transform.Rotate(direction * Time.fixedDeltaTime * _vitesseRot);
    }
}
