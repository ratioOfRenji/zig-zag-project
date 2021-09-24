using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pointCounter : MonoBehaviour
{
    public GameObject winUi;
    public static float points;
    public int valueForStars;
    public int[] starsValue = new int[] { 0,0,0,0,0,0,0,0,0,0 };
    curLevelStars curLevelStars;
    
    //private void OnEnable()
    //{
    //    //PlayerPrefs.DeleteAll();
    //}
  public  void countPoints()
    {
        float x = points / 19;
        if(x < 0.5)
        {
            valueForStars = 1;
        }
        if((x< 0.8) &&(x> 0.5))
        {
            valueForStars = 2;
        }
        if (x >= 0.8)
        {
            valueForStars = 3;
        }
        //Debug.Log(x);
        //int newScene = SceneManager.GetActiveScene().buildIndex + 1;
        //for (int i = 0; i < 10; i++)
        //{
        //    if(SceneManager.GetActiveScene().buildIndex  == i)
        //    {
        //        starsValue[i] = valueForStars;
                
        //    }
        //}
        if(winUi.activeInHierarchy == true)
        { 
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            PlayerPrefs.SetInt("_starsLvlOne", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            PlayerPrefs.SetInt("_starsLvlTwo", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            PlayerPrefs.SetInt("_starsLvlThree", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            PlayerPrefs.SetInt("_starsLvlFour", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("_starsLvlFive", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            PlayerPrefs.SetInt("_starsLvlSix", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            PlayerPrefs.SetInt("_starsLvlSeven", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            PlayerPrefs.SetInt("_starsLvlEight", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            PlayerPrefs.SetInt("_starsLvlNine", valueForStars);
        }
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            PlayerPrefs.SetInt("_starsLvlTen", valueForStars);
        }
            curLevelStars = GetComponent<curLevelStars>();
            curLevelStars.curLvlStars();
            points = 0;
        }
    }
    private void Update()
    {
        //PlayerPrefs.DeleteAll();
        //countPoints();
    }
}
