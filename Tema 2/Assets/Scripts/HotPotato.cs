using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotPotato : MonoBehaviour
{
    private int Counter;
    public Color colorMat;

    // Start is called before the first frame update
    void Start()
    {
        Counter = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = colorMat;
        
    }

    private void OnMouseDown()
    {
        colorMat = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        transform.localScale += 2 * Vector3.one;
        Counter--; // Al final a Counter le restamos 1
        
        if (Counter <= 0)
        {
            Destroy(gameObject);
        }
    }
}
