using UnityEngine;

public class Trig_Del_4 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint4();
        }

        Debug.Log("Something Entered");
    }
}
