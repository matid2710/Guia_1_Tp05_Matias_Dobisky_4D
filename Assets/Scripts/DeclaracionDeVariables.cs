using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    public int numero_entero = 5;
    public float numero_decimal = 2.5f;
    public string texto = "hola mati";
    public bool es_verdadero = true; 


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("entero :" + numero_entero);
        Debug.Log("decimal :" + numero_decimal);
        Debug.Log("texto :" + texto);
        Debug.Log("bool :" + es_verdadero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
