using UnityEngine;
using UnityEngine.UIElements;

public class Bouncyhazard : MonoBehaviour
{
    public Vector3 startposition;
    public float Delta = 2f; 
    public float Speed = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = startposition;
        vel.x += Delta * Mathf.Sin(Time.time * Speed); //this is awesome
        transform.position = vel;

    }
}
