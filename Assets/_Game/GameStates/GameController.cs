using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game Data")]
    [SerializeField] private float _tapLimitDuration = 2.5f;

    [Header("Game Dependencies")]
    [SerializeField] private Unit _playerUnitPrefab;

    [SerializeField] private Transform _playerUnitSpawnLocation;

    [SerializeField] public Transform _playerUnitSpawnLocation_lv_2;

    [SerializeField] public Transform _playerUnitSpawnLocation_lv_3;

    [SerializeField] private UnitSpawner _unitSpawner;

    [SerializeField] private InputBroadcaster _input;

    public AudioSource _setupTrigger;

    public AudioSource _gameplayTrigger;


    public float TapLimitDuration => _tapLimitDuration;
    public Unit PlayerUnitPrefab => _playerUnitPrefab;
    public Transform PlayerUnitSpawnLocation => _playerUnitSpawnLocation;
    public UnitSpawner UnitSpawner => _unitSpawner;
    public InputBroadcaster Input => _input;


}
