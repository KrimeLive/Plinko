using UnityEngine;

public class Trig_Del_5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint5();
        }

        Debug.Log("Something Entered");
    }
}
