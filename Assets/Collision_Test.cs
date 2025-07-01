using UnityEngine;

public class Collision_Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(" Non trigger Collider entering Collision");
    }
}