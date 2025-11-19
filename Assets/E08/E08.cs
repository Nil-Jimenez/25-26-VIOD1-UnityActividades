using System.Globalization;
using UnityEngine;

public class E08 : MonoBehaviour
{
    public int number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            Debug.Log(number * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

