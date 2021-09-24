using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactivity : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desplY * Time.deltaTime);

        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.left * desplX * Time.deltaTime);

    }
}
