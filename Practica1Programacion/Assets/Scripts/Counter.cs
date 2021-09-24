using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] Text MyText;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

  
    IEnumerator Cronometro()
    {

      for(int n = 0; n <= 50 ; n++)
        {
            MyText.text = "Contador: " + n;
            yield return new WaitForSeconds(speed);
            if(n == 49)
            {
                StopCoroutine("Cronometro");
            }

        }

    }
}
