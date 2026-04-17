using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos_personalizados : MonoBehaviour
{
    public float num1;
    public float num2;
    public float suma;
    public float resta;
    public float multiplicacion;
    public float division;

    // Start is called before the first frame update
    void Start()
    {
        
    suma = num1 + num2;
    resta = num1 - num2;
    multiplicacion = num1 * num2;


    if(num2 != 0){
        division = num1 / num2;
    }
    else{
        division = 0;
        
        Debug.Log("no se puede dividr por 0");
    }
    
    Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + suma);
    Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + resta);
    Debug.Log("El resultado de la multiplicacion entre " + num1 + " y " + num2 + " es: " + multiplicacion);
    Debug.Log("El resultado de la division entre " + num1 + " y " + num2 + " es: " + division);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
