using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class E15 : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        int playerA = 0;
        int playerB = 0;

        int playerBwin = 0;
        int playerAwin = 0;

        while (true)
        {
            playerA = Random.Range(1, 4);
            playerB = Random.Range(1, 4);

            if (playerA == playerB)
            {
                Debug.Log("Empate");
            }
            if (playerA == 1 && playerB == 2)
            {
                playerBwin ++;
                Debug.Log("Punto para playerB");
            }
            if (playerA == 1 && playerB == 3)
            {
                playerAwin ++;
                Debug.Log("Punto para playerA");
            }
            else if (playerA == 2 && playerB == 1)
            {
                playerAwin++;
                Debug.Log("Punto para playerA");
            }
            else if (playerA == 2 && playerB == 3)
            {
                playerBwin++;
                Debug.Log("Punto para playerB");
            }
            else if (playerA == 3 && playerB == 1)
            {
                playerBwin++;
                Debug.Log("Punto para playerB");
            }
            else if (playerA == 3 && playerB == 2)
            {
                playerAwin++;
                Debug.Log("Punto para playerA");
            }




            if (playerBwin == 5)
            {
                Debug.Log("Ha ganado PlayerB");
                break;
            }
            if (playerAwin == 5)
            {
                Debug.Log("Ha ganado PlayerA");
                break;
            }


        }



    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
}
