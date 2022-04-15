using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear una variable entera que pueda ser modificada desde el Inspector.
//Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al valor de la variable “dia”. 
//Si el día no está en el rango  permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 

//public string nombre;
// Start is called before the first frame update
//void Start()
//{
    //switch (nombre)
    //{
       // case "nicolas":
         //   Debug.Log("alumno de ort");
           // break;

        //case "shai":
          //  Debug.Log("alumno de ort");
            //break;

  //  }

//}
public class ej08yejemplodeswitch : MonoBehaviour
   
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
    switch (dia)
     {
        case 1:
            Debug.Log("Es domingo");
            break;

            case 2:
                Debug.Log("Es lunes");
                break;
            case 3:
                Debug.Log("Es martes");
                break;
            case 4:
                Debug.Log("Es miercoles");
                break;
            case 5:
                Debug.Log("Es jueves");
                break;
            case 6:
                Debug.Log("Es viernes");
                break;
            case 7:
                Debug.Log("Es sabado");
                break;
            default :
                Debug.Log("el dia ingresado no es valido");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
