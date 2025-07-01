using Unity.VisualScripting;
using UnityEngine;

public class Trig_Del_2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint2();
        }

        Debug.Log("Something Entered");
    }
}
