using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej11 : MonoBehaviour
{
    public int año;
    public int mes;
    public int dia;
    public string NombredelComprador;
    public string Productosolicitado;
     public int Cantidadsolicitada;
    public int PrecioUnitario;
    int TotalaPagar;

    // Start is called before the first frame update
    void Start()
    {
        TotalaPagar = PrecioUnitario * Cantidadsolicitada;
        Debug.Log("Fecha de Compra: " + año + "/" + mes +"/"+ dia + " Nombre del Comprador: " + NombredelComprador + " Producto solicitado: " +Productosolicitado+" Cantidad solicitada: " +Cantidadsolicitada+ 
            " Precio Unitario: $ " + PrecioUnitario + " Total a Pagar: $ " + TotalaPagar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
