using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioClip startingSong;
    //[SerializeField] Text highScoreTextView;

    void Start()
    {

        if (startingSong != null)
        {
            AudioManager.Instance.PlaySong(startingSong);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
