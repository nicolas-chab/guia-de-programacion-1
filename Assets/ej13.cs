using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej13 : MonoBehaviour
{
    public int horas;
    int paga;
    int horasextra;
    int pagaextra;
    int pagatot;
    // Start is called before the first frame update
    void Start()
    {
        
      
          
       
        if (horas > 40)
        {
            horasextra = horas - 40;
            pagaextra = (horasextra * 20);
            paga = 40 * 16;
            pagatot = paga + pagaextra;
            Debug.Log("cantidad de horas " + horas + " salario correspondiente:$ " + pagatot);
        }
        else
        {
            paga = horas * 16;
            Debug.Log("cantidad de horas " + horas + " salario correspondiente " + paga);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
