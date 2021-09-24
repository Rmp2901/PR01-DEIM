using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        while (num1 <= 15)
        {
            if (num1 < 15)
            {
                print("El valor es menor que 15");
            }
            else if (num1 >=3 && num1 <= 15)
            {
                print("El valor es" + num1);
            }
            else
            {
                print("El valor es 15");
            }

            num1++;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
