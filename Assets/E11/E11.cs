using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class E11 : MonoBehaviour
{
    public int playerA;
    public int playerB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1 Rock
        //2 Paper
        //3 Scissors

        playerB = Random.Range(1, 4);

        if (playerA == playerB)
        {
            Debug.Log("Empate");
        }
        else if(playerA == 1 && playerB == 2)
        {
            Debug.Log("Gana playerB");
        }
        else if(playerA == 1 && playerB == 3)
        {
            Debug.Log("Gana playerA");
        }
        else if (playerA == 2 && playerB == 1)
        {
            Debug.Log("Gana playerA");
        }
        else if (playerA == 2 && playerB == 3)
        {
            Debug.Log("Gana playerB");
        }
        else if (playerA == 3 && playerB == 1)
        {
            Debug.Log("Gana playerB");
        }
        else if (playerA == 3 && playerB == 2)
        {
            Debug.Log("Gana playerA");
        }


    }

// Update is called once per frame
void Update()
    {
        
    }
}
