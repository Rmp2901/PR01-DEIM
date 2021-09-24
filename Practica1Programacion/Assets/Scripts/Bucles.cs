using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        while (num1 < 15)
        {
            num1++;
        }
        print (num1);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
