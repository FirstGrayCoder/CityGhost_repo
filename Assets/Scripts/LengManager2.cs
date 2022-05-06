using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengManager2 : MonoBehaviour
{
    [SerializeField] private Text _PauseUKR;
    [SerializeField] private Text _PauseEng;
    [SerializeField] private Text _SettingsUKR;
    [SerializeField] private Text _SettingsQuitEng;

    [SerializeField] private Text _LoseBigUKR;
    [SerializeField] private Text _LoseBigEng;
    [SerializeField] private Text _LoseSmallUKR;
    [SerializeField] private Text _LoseSmallEng;
    [SerializeField] private Text _LoseButtonUKR;
    [SerializeField] private Text _LoseButtonEng;
    // Start is called before the first frame update
void Awake()
    {
        //  _checkLeng = PlayerPrefs.GetInt("_checkLeng");
        //  PlayerPrefs.SetInt("_checkLeng", _checkLeng);

        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian) 
        {
            // _checkLeng = 0;
            _PauseUKR.gameObject.SetActive(true);
            _PauseEng.gameObject.SetActive(false);
            _SettingsUKR.gameObject.SetActive(true);
            _SettingsQuitEng.gameObject.SetActive(false);
            _LoseBigUKR.gameObject.SetActive(true);
            _LoseBigEng.gameObject.SetActive(false);
            _LoseSmallUKR.gameObject.SetActive(true);
            _LoseSmallEng.gameObject.SetActive(false);
            _LoseButtonUKR.gameObject.SetActive(true);
            _LoseButtonEng.gameObject.SetActive(false);
        }
        else if(Application.systemLanguage == SystemLanguage.English ) 
        {
           // _checkLeng = 1;
            _PauseUKR.gameObject.SetActive(false);
            _PauseEng.gameObject.SetActive(true);
            _SettingsUKR.gameObject.SetActive(false);
            _SettingsQuitEng.gameObject.SetActive(true);
            _LoseBigUKR.gameObject.SetActive(false);
            _LoseBigEng.gameObject.SetActive(true);
            _LoseSmallUKR.gameObject.SetActive(false);
            _LoseSmallEng.gameObject.SetActive(true);
            _LoseButtonUKR.gameObject.SetActive(false);
            _LoseButtonEng.gameObject.SetActive(true);
        }
        else 
        {
            //_checkLeng = 1;
            _PauseUKR.gameObject.SetActive(false);
            _PauseEng.gameObject.SetActive(true);
            _SettingsUKR.gameObject.SetActive(false);
            _SettingsQuitEng.gameObject.SetActive(true);
            _LoseBigUKR.gameObject.SetActive(false);
            _LoseBigEng.gameObject.SetActive(true);
            _LoseSmallUKR.gameObject.SetActive(false);
            _LoseSmallEng.gameObject.SetActive(true);
            _LoseButtonUKR.gameObject.SetActive(false);
            _LoseButtonEng.gameObject.SetActive(true);
        }
    }
}
