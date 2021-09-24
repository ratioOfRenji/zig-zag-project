using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataHandler : MonoBehaviour
{
    int starsLvlOne;
    int starsLvlTwo;
    int starsLvlThree;
    int starsLvlFour;
    int starsLvlFive;
    int starsLvlSix;
    int starsLvlSeven;
    int starsLvlEight;
    int starsLvNine;
    int starsLvlTen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void saveData()
    {
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);
        PlayerPrefs.SetInt("_starsLvlOne", starsLvlOne);

    }
}
