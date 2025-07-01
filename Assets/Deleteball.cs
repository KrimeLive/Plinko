using UnityEngine;

public class Deleteball : MonoBehaviour
{
    public string targetTag = "Circle";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            Destroy(gameObject);
        }
    }

}
