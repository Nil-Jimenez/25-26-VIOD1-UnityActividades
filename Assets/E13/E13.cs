using UnityEngine;

public class E13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int count = 0;
        while (count < 100)
        {
            count++;
            Debug.Log(Random.Range(0, 9));
        }
           

           

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
