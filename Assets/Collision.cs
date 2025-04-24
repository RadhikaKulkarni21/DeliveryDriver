using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Learn to drive");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ran over something");
    }
}
