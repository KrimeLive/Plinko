using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mycircle;

    
        
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            
            float spawnPointX = Random.Range((float)-1.0, (float)1.0);
            float spawnPointy = Random.Range(0, 0);
            
            Vector3 spawnPosition          = new Vector3(spawnPointX, spawnPointy, 0);

            Instantiate(mycircle, spawnPosition, Quaternion.identity);
        }

    }












}
