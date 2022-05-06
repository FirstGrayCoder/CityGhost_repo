using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scorePlane;
    public static int bestscorePlane;
    public static int scoreTank;
    public static int bestscoreTank;
    public Text scoreDispleyPlane;
    public Text scoreDispleyTank;
    public static int LoseNumber;
    public Text LoseCount;
    [SerializeField] private string namePlane;
    [SerializeField] private string nameTank;
    [SerializeField] private string nameEscape;
    [SerializeField] private string nameBestScore;
    // Start is called before the first frame update

    void Awake()
    {
        if (LenguageManager._checkLeng == 0 )
        {
            namePlane = "Літаки: ";
            nameTank = "Танки: ";
            nameEscape = "Прорвались: ";
            nameBestScore = "/ н.р. ";
            LenguageManager._checkLeng = 0;
        }
        else if (LenguageManager._checkLeng == 1 )
        {
            namePlane = "Plane: ";
            nameTank = "Tank: ";
            nameEscape = "Escape: ";
            nameBestScore = "/ b.s. ";
            LenguageManager._checkLeng = 1;
        }
    }
    void Start()
    {
        scorePlane = PlayerPrefs.GetInt("scorePlane");
        scoreTank = PlayerPrefs.GetInt("scoreTank");
        LoseNumber = 0;
        PlayerPrefs.SetInt("scorePlane", scorePlane);
        PlayerPrefs.SetInt("scoreTank", scoreTank);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        scoreDispleyPlane.text = namePlane + scorePlane.ToString() + nameBestScore + bestscorePlane.ToString();
        if(scorePlane > bestscorePlane) {
            bestscorePlane = scorePlane;
            if (bestscorePlane == 3) {
            }
        }

        scoreDispleyTank.text = nameTank + scoreTank.ToString() + nameBestScore + bestscoreTank.ToString();
        if(scoreTank > bestscoreTank) {
            bestscoreTank = scoreTank;
        }
        LoseCount.text = nameEscape + LoseNumber.ToString() + "/10";
        if (LoseNumber == 10 ) 
        {
            LoseNumber = 10;

        }
    }



}
