using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject _setupPopup;
    public GameObject _playPopup;
    public GameObject _lvlButton;
    public GameObject _playButton;

    public void Trigger()
    {
        if (_setupPopup.activeInHierarchy == false)
        {
            _setupPopup.SetActive(true);
            _playPopup.SetActive(false);
            _lvlButton.SetActive(true);
            _playButton.SetActive(true);
        }
        else
        {
            _setupPopup.SetActive(false);
            _playPopup.SetActive(true);
            _lvlButton.SetActive(false);
            _playButton.SetActive(false);
        }
    }
}
