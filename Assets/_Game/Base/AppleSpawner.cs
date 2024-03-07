using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject _applePrefab;

    private void Update()
    {
        //Vector3 randomSpawnPosition = new Vector3(Random.Range(-12, 13), 2, (Random.Range(-12, 13)));
        //Instantiate(_applePrefab, randomSpawnPosition, Quaternion.identity);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
