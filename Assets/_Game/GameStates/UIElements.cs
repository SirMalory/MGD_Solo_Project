using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class UIElements : MonoBehaviour
{
    [SerializeField] AudioClip _startingSong;
    [SerializeField] Camera _camera;
    [SerializeField] Unit _player;

    private GameController _controller;
    public GameSetupState _setupState;
    public float _cameraSet = 0;
    public AudioSource _lvlTrigger;

    void Start()
    {
        if (_startingSong != null)
        {
            AudioManager.Instance.PlaySong(_startingSong);
        }

    }
    public void LeaveGame()
    {
        Debug.Log("Exiting Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void SwapCameraPosition()
    {
        Debug.Log("Level Switch");
        if (_cameraSet == 0)
        {
            _camera.transform.position = new Vector3(18, 10.15f, -18);
            _camera.transform.rotation = Quaternion.Euler(40, 90, 0);
            _cameraSet += 1;
            _player.Level_2();
        }
        else if (_cameraSet == 1)
        {
            _camera.transform.position = new Vector3(0, 10.15f, -18);
            _camera.transform.rotation = Quaternion.Euler(40, 180, 0);
            _cameraSet += 1;
            _player.Level_3();
        }
        else
        {
            _camera.transform.position = new Vector3(0, 10.15f, -18);
            _camera.transform.rotation = Quaternion.Euler(40, 0, 0);
            _cameraSet -= 2;
            _player.Level_1();
        }
    }

    public void Transition()
    {
        _lvlTrigger.Play();
    }


}
