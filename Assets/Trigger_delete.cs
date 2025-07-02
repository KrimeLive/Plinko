using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger_delete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint1();
            
        }

        Debug.Log("Point scored");
    }
    



}