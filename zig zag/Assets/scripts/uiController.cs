using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiController : MonoBehaviour
{
    public GameObject[] uiToClose;
    public GameObject lvlUi;
    public GameObject winUi;
    public GameObject restartUI;
    public GameObject player;
    public int[] levelsStars;
    int newScene;
    private void OnEnable()
    {
       newScene = SceneManager.GetActiveScene().buildIndex + 1;
        levelsStars = new int[] { PlayerPrefs.GetInt("_starsLvlOne"), PlayerPrefs.GetInt("_starsLvlTwo"), PlayerPrefs.GetInt("_starsLvlThree"), PlayerPrefs.GetInt("_starsLvlFour"), PlayerPrefs.GetInt("_starsLvlFive"), PlayerPrefs.GetInt("_starsLvlSix"),
    PlayerPrefs.GetInt("_starsLvlSeven"), PlayerPrefs.GetInt("_starsLvlEight"), PlayerPrefs.GetInt("_starsLvlNine"), PlayerPrefs.GetInt("_starsLvlTen")};
    }
   public void LoadNextScene()
    {
        SceneManager.LoadScene(newScene);
    
    }
    private void Update()
    {
        if(player == null)
        {
            restartUi();
        }
    }
    public void openLvlUI()
    {
        //for (int i = 0; i < uiToClose.Length; i++)
        //{
        //    uiToClose[i].SetActive(false);
        //}
        SceneManager.LoadScene(11);
    }
  public  void openWinLvlUi()
    {
      winUi.SetActive(true);
    }
    public void restartUi()
    {
        if(winUi.activeInHierarchy == false)
        {
            StartCoroutine(waitBeforeStop());
            IEnumerator waitBeforeStop()
            {
                yield return new WaitForSeconds(1);
                restartUI.SetActive(true);
            }
            
        }
    }
   public void toMainMenu()
    {
        for (int i = 0; i < uiToClose.Length; i++)
        {
            uiToClose[i].SetActive(false);
        }
        SceneManager.LoadScene(0);
    }
    public void reloadScene()
    { pointCounter.points = 0;
        StartCoroutine(waitBeforeStop());
        IEnumerator waitBeforeStop()
        {
            yield return new WaitForSeconds(1);
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
       
    }
    public void loadMaximumOpenedScene()
    {
        for (int i = 0; i < levelsStars.Length; i++)
        {
            if(levelsStars[i] == 0)
            {
                if(i+1 <= 10)
                {
 SceneManager.LoadScene(i+1);
                break;
                }
               else if(i+1 > 10)
                {
                    SceneManager.LoadScene(10);
                    break;
                }
            }
        }
    }

    public void Quit()
    {
       Application.Quit();
    }


    //   //
      //

    //   //
    ///////

    public void loadLvlOne()
    {
        SceneManager.LoadScene(1);
    }
    public void loadLvlTwo()
    {
        if(PlayerPrefs.GetInt("_starsLvlOne") >=1)
        {
          SceneManager.LoadScene(2);
        }
        
    }
    public void loadLvlThree()
    {
        if (PlayerPrefs.GetInt("_starsLvlTwo") >= 1)
        { 
            SceneManager.LoadScene(3);
        }
    }
    public void loadLvlFour()
    {
        if (PlayerPrefs.GetInt("_starsLvlThree") >= 1)
        {
            SceneManager.LoadScene(4); }
    }
    public void loadLvlFive()
    {
        if (PlayerPrefs.GetInt("_starsLvlFour") >= 1)
        {
            SceneManager.LoadScene(5); }
    }
    public void loadLvlSix()
    {
        if (PlayerPrefs.GetInt("_starsLvlFive") >= 1)
        { 
            SceneManager.LoadScene(6);}
    }
    public void loadLvlSeven()
    {
        if (PlayerPrefs.GetInt("_starsLvlSix") >= 1)
        { 
            SceneManager.LoadScene(7);}
    }
    public void loadLvlEight()
    {
        if (PlayerPrefs.GetInt("_starsLvlSeven") >= 1)
        {
            SceneManager.LoadScene(8);
        }
    }
    public void loadLvlNine()
    {
        if (PlayerPrefs.GetInt("_starsLvlEight") >= 1)
        {
            SceneManager.LoadScene(9);
        }
    }

    public void loadLvlTen()
    {
        if (PlayerPrefs.GetInt("_starsLvlNine") >= 1)
        {
            SceneManager.LoadScene(10);
        }
    }
}
