using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject _applePrefab;
    private bool _Spawn = false;

    private void Awake()
    {
        //SpawnApples();
    }
    private void Update()
    {
        if (_Spawn == true)
        {
            SpawnApples();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SpawnApples();
            Destroy(this.gameObject);
            _Spawn = true;
        }
    }

    public void SpawnApples()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-12, 13), 2, (Random.Range(-12, 13)));
        Instantiate(_applePrefab, randomSpawnPosition, Quaternion.identity);
        _Spawn = false;
    }
}
