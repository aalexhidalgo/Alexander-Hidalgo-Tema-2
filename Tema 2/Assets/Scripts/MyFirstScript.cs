using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    /*
    
    private float playerSpeed = 5.25f;
    public string playerName = "Alexander";
    [SerializeField] private bool game0ver= false;
    

    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    public int x = 5;
    public int y = 2;
    public int playerAge = 17;

   
    */

    public bool isRaining = false;
    public bool isCold;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + "=" + (x - y));
        Debug.Log(string.Format ("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format ("Division: {0} / {1} = {2}", x, y, x / y));
        
        if (playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");

        }else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres un ni�o");
        }
        

        if (x == 5 || y <= 2)
        {
            Debug.Log("Verdadero");
        }
        else
        {
            Debug.Log("Falso");
        }
        */

        if (isRaining == true)
        {
            if (isCold == true)
            {
                Debug.Log("Lleva paraguas y sudadera");
            }
            else
            {
                Debug.Log("Lleva paraguas.");
            }
        }
        else
        {
            if (isCold == true)
            {
                Debug.Log("Lleva una sudadera.");
            }
            else
            {
                Debug.Log("Disfruta del d�a");
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
