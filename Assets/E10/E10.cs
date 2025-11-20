using UnityEngine;

public class E10 : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int operation = Random.Range(0, 5);
        int numA = Random.Range(0, 9);
        int numB = Random.Range(0, 9);

        switch (operation)
        {
            case 1:
                Debug.Log(numA + numB); break;
            case 2:
                Debug.Log(numA - numB); break;
            case 3:
                Debug.Log(numA * numB); break;
            case 4:
                Debug.Log(numA / numB); break;
            case 5:
                Debug.Log(numA % numB); break;


        }

    }
        
        // Update is called once per frame
    void Update()
    {
        

    }



}
