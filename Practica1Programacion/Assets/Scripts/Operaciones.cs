using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operaciones : MonoBehaviour
{
    [SerializeField] int n1;
    [SerializeField] int n2;
    bool devolver;
    int ResultadoFinal;

    // Start is called before the first frame update
    void Start()
    {
        Operacion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Metodo para las operaciones
    void Operacion()
    {
        ResultadoFinal = n1 * n2;

        if (ResultadoFinal <= 25)
        {
            devolver = true;
        }
        
        else
        {
            devolver = false;
        }

        print("El resultado es: " + devolver);

        return;
    }
}
