using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class curLevelStars : MonoBehaviour
{
    public Sprite empty;
    public Sprite full;
    public Image[] currentLevelStars;
    public TMP_Text _text;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
       // curLvlStars();
    }
   public void curLvlStars()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        string b = i.ToString();
        _text.text = b;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //   PlayerPrefs.SetInt("_starsLvlOne", valueForStars);
            if (PlayerPrefs.GetInt("_starsLvlOne") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlOne") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlOne") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlOne") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (PlayerPrefs.GetInt("_starsLvlTwo") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlTwo") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlTwo") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlTwo") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (PlayerPrefs.GetInt("_starsLvlThree") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlThree") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlThree") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlThree") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (PlayerPrefs.GetInt("_starsLvlFour") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlFour") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlFour") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlFour") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (PlayerPrefs.GetInt("_starsLvlFive") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlFive") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlFive") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlFive") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            if (PlayerPrefs.GetInt("_starsLvlSix") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlSix") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlSix") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlSix") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            if (PlayerPrefs.GetInt("_starsLvlSeven") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlSeven") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlSeven") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlSeven") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            if (PlayerPrefs.GetInt("_starsLvlEight") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlEight") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlEight") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlEight") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            if (PlayerPrefs.GetInt("_starsLvlNine") == 0)
            {
                currentLevelStars[0].sprite = empty;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlNine") == 1)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = empty;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlNine") == 2)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = empty;
            }
            if (PlayerPrefs.GetInt("_starsLvlNine") == 3)
            {
                currentLevelStars[0].sprite = full;
                currentLevelStars[1].sprite = full;
                currentLevelStars[2].sprite = full;
            }
            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                if (PlayerPrefs.GetInt("_starsLvlTen") == 0)
                {
                    currentLevelStars[0].sprite = empty;
                    currentLevelStars[1].sprite = empty;
                    currentLevelStars[2].sprite = empty;
                }
                if (PlayerPrefs.GetInt("_starsLvlTen") == 1)
                {
                    currentLevelStars[0].sprite = full;
                    currentLevelStars[1].sprite = empty;
                    currentLevelStars[2].sprite = empty;
                }
                if (PlayerPrefs.GetInt("_starsLvlTen") == 2)
                {
                    currentLevelStars[0].sprite = full;
                    currentLevelStars[1].sprite = full;
                    currentLevelStars[2].sprite = empty;
                }
                if (PlayerPrefs.GetInt("_starsLvlTen") == 3)
                {
                    currentLevelStars[0].sprite = full;
                    currentLevelStars[1].sprite = full;
                    currentLevelStars[2].sprite = full;
                }
            }
        }

        // Update is called once per frame
      
    }
}
