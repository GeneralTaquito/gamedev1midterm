using UnityEngine;

public class rotatingthinghazard : MonoBehaviour
{
    public float rotate = 50f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotate * Time.deltaTime);
    }
}
