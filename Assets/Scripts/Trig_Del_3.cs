using UnityEngine;

public class Trig_Del_3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint3();
        }

        Debug.Log("Something Entered");
    }
}
