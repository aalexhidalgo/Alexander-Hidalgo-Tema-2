using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "¡Brum, brum!";
    // Variable que guarda el nombre del vehiculo
    [SerializeField] private string name;
    // Variable que guarda el numero de ruedas del vehiculo
    [SerializeField] private int numberWheels = 4;
    // Variable que guarda si tiene sirena
    [SerializeField] private bool hasSiren;

    [SerializeField] private bool isOn = true;




    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log($"Mensaje: {name} tiene {numberWheels} ruedas y hace {sound}");

        if (hasSiren)
        {
            Debug.Log($" {name} tiene sirena");
        }
        else
        {
            Debug.Log($" {name} no tiene sirena");
        }
        */

        if (isOn == true)
        {
            Debug.Log($"{sound}");

        }else if (hasSiren == true)
        {
            Debug.Log($"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no está en marcha");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
