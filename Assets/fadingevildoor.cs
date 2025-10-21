using UnityEngine;

public class fadingevildoor : MonoBehaviour
{
    public Vector3 startposition;
    public float Delta = 2f;
    public float Speed = 1.5f;

    // this is the same thing as bouncyhazard but up n down
    void Start()
    {
        startposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = startposition;
        vel.y += Delta * Mathf.Sin(Time.time * Speed); //this is awesome 2
        transform.position = vel;

    }
}

