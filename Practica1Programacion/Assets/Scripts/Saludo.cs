using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Saludar("Ruben");
        Saludar("Miriam");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Saludar(string nombre = "Desconocido")
    {
        print("Hola " + nombre); 
    }
}
