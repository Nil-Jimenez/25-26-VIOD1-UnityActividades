using UnityEngine;


public class E07 : MonoBehaviour
{
    public int numberA;
    public int numberB;
    public string operation;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        switch(operation)
        {
            case "+":
                Debug.Log(numberA + numberB); break;
            case "-":
                Debug.Log(numberA - numberB); break;
            case "*":
                Debug.Log(numberA * numberB); break;
            case "/":   
                Debug.Log(numberA / numberB); break;
            case "%":  
                Debug.Log(numberA % numberB); break;
            
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
