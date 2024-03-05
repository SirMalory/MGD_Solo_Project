using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class UIElements : MonoBehaviour
{
    [SerializeField] AudioClip _startingSong;
    [SerializeField] Camera _camera;

    public GameSetupState _setupState;
    public float _cameraSet = 0;

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
        //
        Debug.Log("Level Switch");
        if (_cameraSet == 0)
        {
            _camera.transform.position = new Vector3(18, 10.15f, -18);
            _camera.transform.rotation = Quaternion.Euler(40, 90, 0);
            _cameraSet += 1;
        }
        else if (_cameraSet == 1)
        {
            _camera.transform.position = new Vector3(0, 10.15f, -18);
            _camera.transform.rotation = Quaternion.Euler(40, 180, 0);
            _cameraSet += 1;
        }
        else
        {
            _camera.transform.position = new Vector3(0, 10.15f, -18);
            _camera.transform.rotation = Quaternion.Euler(40, 0, 0);
            _cameraSet -= 2;
        }
    }


}
