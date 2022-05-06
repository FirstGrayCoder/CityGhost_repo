using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _panelSettings;
    // Start is called before the first frame update
    [SerializeField] private AudioSource _audioSorce;
    public bool _isSoundOff;
    public void Start() 
    {
        _panelPause.SetActive(false);
        _panelSettings.SetActive(false);
        _isSoundOff = true;
    }
    public void PlayGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PauseGame1()
    {
        Time.timeScale = 0;
        _panelPause.SetActive(true);
        if (_isSoundOff == true)
        {
        _audioSorce.Pause();
        }
    }
    public void PlayAgaine()
    {
        Time.timeScale = 1;
        _panelPause.SetActive(false);
        _panelSettings.SetActive(false);
        if(_isSoundOff == true)
        {
        _audioSorce.Play();
        _isSoundOff = true;
        }
        else return;
    }
       public void PlayAgaine2()
    {
        Time.timeScale = 1;
        _panelSettings.SetActive(false);
    }
    public void Settings()
    {
        Time.timeScale = 0;
        _panelSettings.SetActive(true);
    }

    public void SoundOff()
    {
        _audioSorce.mute = true;
        _isSoundOff = true;
    }
    public void SoundOn()
    {
        if (_isSoundOff == true)
        {
        _audioSorce.mute = false;
        _isSoundOff = true;
        }
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}
