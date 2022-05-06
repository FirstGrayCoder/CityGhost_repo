using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenguageManager : MonoBehaviour
{
    public static int _checkLeng;
    [SerializeField] private Text _PlayUKR;
    [SerializeField] private Text _PlayEng;
    [SerializeField] private Text _QuitUKR;
    [SerializeField] private Text _QuitEng;

    // Start is called before the first frame update
    void Awake()
    {
         _checkLeng = PlayerPrefs.GetInt("_checkLeng");
         PlayerPrefs.SetInt("_checkLeng", _checkLeng);

        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian) 
        {
            _checkLeng = 0;
            _PlayUKR.gameObject.SetActive(true);
            _PlayEng.gameObject.SetActive(false);
            _QuitUKR.gameObject.SetActive(true);
            _QuitEng.gameObject.SetActive(false);
        }
        else if(Application.systemLanguage == SystemLanguage.English ) 
        {
            _checkLeng = 1;
            _PlayUKR.gameObject.SetActive(false);
            _PlayEng.gameObject.SetActive(true);
            _QuitUKR.gameObject.SetActive(false);
            _QuitEng.gameObject.SetActive(true);
        }
        else 
        {
            _checkLeng = 1;
            _PlayUKR.gameObject.SetActive(false);
            _PlayEng.gameObject.SetActive(true);
            _QuitUKR.gameObject.SetActive(false);
            _QuitEng.gameObject.SetActive(true);
        }
    }

    // public void Ukr()
    // {
    //     _checkLeng = 0;
    //         _PlayUKR.gameObject.SetActive(true);
    //         _PlayEng.gameObject.SetActive(false);
    //         _QuitUKR.gameObject.SetActive(true);
    //         _QuitEng.gameObject.SetActive(false);

    // }

    // public void Eng()
    // {
    //     _checkLeng = 1;
    //         _PlayUKR.gameObject.SetActive(false);
    //         _PlayEng.gameObject.SetActive(true);
    //         _QuitUKR.gameObject.SetActive(false);
    //         _QuitEng.gameObject.SetActive(true);

    // }


}
