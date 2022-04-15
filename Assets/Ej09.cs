using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string nom1;
    public string nom2;
    public string nom3;
    public int mon1;
    public int mon2;
    public int mon3;
   

    // Start is called before the first frame update
    void Start()
    {
        float por1;
            float por2;
            float por3;
        float total = mon1 + mon2 + mon3;
        por1 = mon1 / total * 100;
        por2 = mon2 / total * 100;
        por3 = mon3 / total * 100;

        Debug.Log("Nombre:" + nom1 + " monto aportado:$" + mon1 + ", Porcentaje del capital: %" + por1 + ", Monto total aportado: $" + total);
        Debug.Log("Nombre:" + nom2 + " monto aportado:$" + mon2 + ", Porcentaje del capital: %" + por2 + ", Monto total aportado: $" + total);
        Debug.Log("Nombre:" + nom3 + " monto aportado:$" + mon3 + ", Porcentaje del capital: %" + por3 + ", Monto total aportado: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
