using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int cantTaxis;
    public int cantDias;
    public int cantDiasLluvia;

    // Start is called before the first frame update
    void Start()
    {
        int sumaDias = cantDias - cantDiasLluvia;
        int cantLitrosNormal = (cantTaxis * 90) * 130;
        int cantLitrosLluvia = (cantTaxis * 110) * 130;
        int sumaLitros = cantLitrosNormal + cantLitrosLluvia;

        //Requerimientos:
        if (cantDias < 5)
        {
            Debug.Log("La cantidad de dias es menor a '5'");
        }
        else if (cantDiasLluvia < 0 && cantDiasLluvia > cantDias)
        {
            Debug.Log("La cantidad de dias de lluvia es negativa o es mayor a la cantidiad de dias total");
        }
        else
        {
            Debug.Log("Una flota de " + cantTaxis + " unidades trabajando durante " + cantDias + " días implicará un gasto de " + sumaLitros + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
