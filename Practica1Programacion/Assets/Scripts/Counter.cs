using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] Text MyText;
    [SerializeField] float speed;
    int n;
    bool contadorEncendido;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            if (contadorEncendido == false)
            {
                StartCoroutine("Cronometro");
                contadorEncendido = true;
            }
    

            else
            {
                StopCoroutine("Cronometro");
                contadorEncendido = false;
            }
        }
    }

    IEnumerator Cronometro()
    {

        for (; ; n++ )
        {
            MyText.text = "Contador: " + n;
            yield return new WaitForSeconds(speed);
            
        }
     
        

    }
}
