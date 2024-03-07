using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    List<GameObject> players = new List<GameObject>();
    [SerializeField] private Transform levelTransform_lv1;
    [SerializeField] private Transform levelTransform_lv2;
    [SerializeField] private Transform levelTransform_lv3;

    public GameObject _player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level_1()
    {
        DestroyPlayers();
        GameObject clone;
        clone = Instantiate(_player, transform.position, transform.rotation) as GameObject;
        players.Add(clone);
        clone.transform.position = levelTransform_lv1.position;
        Debug.Log("Lvl1");
    }

    public void Level_2()
    {
        DestroyPlayers();
        GameObject clone;
        clone = Instantiate(_player, transform.position, transform.rotation) as GameObject;
        players.Add(clone);
        clone.transform.position = levelTransform_lv2.position;
        Debug.Log("Lvl2");
    }
    public void Level_3()
    {
        DestroyPlayers();
        GameObject clone;
        clone = Instantiate(_player, transform.position, transform.rotation) as GameObject;
        players.Add(clone);
        clone.transform.position = levelTransform_lv3.position;
        Debug.Log("Lvl3");
    }

    public void DestroyPlayers()
    {
        foreach (GameObject gameObject in players)
        {
            Destroy(gameObject);
        }
        players.Clear();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            Debug.Log("EATEN");
            Destroy(other.gameObject);
        }
    }
}
