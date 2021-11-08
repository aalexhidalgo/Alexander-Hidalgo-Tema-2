using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
    private int RandNumber;
    public int MyNum = 5;
    private int Counter; // Contador de intentos

    // Start is called before the first frame update
    void Start()
    {
        RandNumber = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            MyNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(MyNum);
            Counter++; // A la variable Counter le sumamos 1
        }
    }

    public void CompareToRandomNumber(int userNum)
    {
        
        if (userNum > RandNumber)
        {
            Debug.Log("¡El número que yo había pensado es más pequeño!");
        }
        if (userNum == RandNumber)
        {
            Debug.Log($"¡HAS ACERTADO! El número es igual al que he pensado {RandNumber}!");
            Debug.Log($"Has utilizado {Counter} intentos");
        }
        if (userNum < RandNumber)
        {
            Debug.Log("¡El número que yo había pensado es más grande!");
            
        }
    }
}
