using UnityEngine;


public class E18 : MonoBehaviour
{
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = new Vector3(0, 0, 0);
        dir.y += +1;
        dir.x += -1;
        transform.position += dir * speed * Time.deltaTime;
    }
}
