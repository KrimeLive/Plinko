using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mycircle;
    public float cooldownTime = 2f;

    private bool canSpawn = true;

        
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            
            float spawnPointX = Random.Range((float)-1.0, (float)1.0);
            float spawnPointy = Random.Range(0, 0);
            
            Vector3 spawnPosition= transform.position + new Vector3(spawnPointX, spawnPointy, 0);

            Instantiate(mycircle,spawnPosition, Quaternion.identity);

            canSpawn = false;
            StartCoroutine(SpawnCooldown());
        }
        


    }

  private IEnumerator SpawnCooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        canSpawn=true;
    }

}
