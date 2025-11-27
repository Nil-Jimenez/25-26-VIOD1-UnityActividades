using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.PlayerSettings;

public class E22 : MonoBehaviour
{

    public float speed;
    public float speedTarget;
    public GameObject target;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = new Vector3(0, 0, 0);

       

        

        if (Keyboard.current.wKey.isPressed)
        {
            dir.y = 1;

        }
        if (Keyboard.current.sKey.isPressed)
        {
            dir.y = -1;

        }
        if (Keyboard.current.aKey.isPressed)
        {
            dir.x = -1;

        }
        if (Keyboard.current.dKey.isPressed)
        {
            dir.x = 1;
        }

        transform.position += dir * speed * Time.deltaTime;

       
        
        target.transform.position = Vector3.Lerp(target.transform.position, transform.position, 2 * Time.deltaTime);
            
        

        
    }
}