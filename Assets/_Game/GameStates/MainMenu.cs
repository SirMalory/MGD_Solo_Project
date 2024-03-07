using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioClip _startingSong;
    public AudioSource _MenuCue;

    void Start()
    {

        if (_startingSong != null)
        {
            AudioManager.Instance.PlaySong(_startingSong);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        _MenuCue.Play();
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene("MainMenu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
