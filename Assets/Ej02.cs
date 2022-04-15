using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int suma;
        int producto;
    // Start is called before the first frame update
    void Start()
    {
        suma = num1 + num2;
        producto = num1 * num2;
        Debug.Log("la suma da " + suma + " y el producto da " + producto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
