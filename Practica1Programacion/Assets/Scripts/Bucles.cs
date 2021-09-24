using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    int num1;
    int recuento;

    // Start is called before the first frame update
    void Start()
    {
        recuento = 0; 
        while (num1 != 5) //valor que intentaremos conseguir de forma aleatoria
        {
            num1 = Random.Range(1, 51); //Generador de valores

            Debug.Log("Ha salido el valor: " + num1); // Dice que valor hemos obtenido
            recuento++;
        }

        Debug.Log("Se termino, han salido un total de: " + recuento + " valores");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
