using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starsImages : MonoBehaviour
{
    public Image[] starslvlOne;
    public Image[] starslvlTwo; 
    public Image[] starslvlThree;
    public Image[] starslvlFour;
    public Image[] starslvlFive;
    public Image[] starslvlSix;
    public Image[] starslvlSeven;
    public Image[] starslvlEight;
    public Image[] starslvlNine;
    public Image[] starslvlTen;
    public GameObject[] lockers;
    public GameObject test;
    public Sprite empty;
    public Sprite full;
    public int[] levelsStars;

    public Image[] curLevelStars;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        levelsStars = new int[] { PlayerPrefs.GetInt("_starsLvlOne"), PlayerPrefs.GetInt("_starsLvlTwo"), PlayerPrefs.GetInt("_starsLvlThree"), PlayerPrefs.GetInt("_starsLvlFour"), PlayerPrefs.GetInt("_starsLvlFive"), PlayerPrefs.GetInt("_starsLvlSix"),
    PlayerPrefs.GetInt("_starsLvlSeven"), PlayerPrefs.GetInt("_starsLvlEight"), PlayerPrefs.GetInt("_starsLvlNine"), PlayerPrefs.GetInt("_starsLvlTen")};
        getLockers();
        starsLvlOne();
        starsLvlTwo();
        starsLvlThree();
        starsLvlFour();
        starsLvlFive();
        starsLvlSix();
        starsLvlSeven();
        starsLvlEight();
        starsLvlNine();
        starsLvlTen();
    }
    // Update is called once per frame
    void Update()
    {
        
      

        //test.gameObject.GetComponent<SpriteRenderer>().sprite = full;
    }
    private void starsLvlOne()
    {
        if(PlayerPrefs.GetInt("_starsLvlOne") == 0)
        {
            starslvlOne[0].sprite = empty;
            starslvlOne[1].sprite = empty;
            starslvlOne[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlOne") == 1)
        {
            starslvlOne[0].sprite = full;
            starslvlOne[1].sprite = empty;
            starslvlOne[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlOne") == 2)
        {
            starslvlOne[0].sprite = full;
            starslvlOne[1].sprite = full;
            starslvlOne[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlOne") == 3)
        {
            starslvlOne[0].sprite = full;
            starslvlOne[1].sprite = full;
            starslvlOne[2].sprite = full;
        }
    }
    private void starsLvlTwo()
    {
        if (PlayerPrefs.GetInt("_starsLvlTwo") == 0)
        {
            starslvlTwo[0].sprite = empty;
            starslvlTwo[1].sprite = empty;
            starslvlTwo[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlTwo") == 1)
        {
            starslvlTwo[0].sprite = full;
            starslvlTwo[1].sprite = empty;
            starslvlTwo[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlTwo") == 2)
        {
            starslvlTwo[0].sprite = full;
            starslvlTwo[1].sprite = full;
            starslvlTwo[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlTwo") == 3)
        {
            starslvlTwo[0].sprite = full;
            starslvlTwo[1].sprite = full;
            starslvlTwo[2].sprite = full;
        }
    }

    private void starsLvlThree()
    {
        if (PlayerPrefs.GetInt("_starsLvlThree") == 0)
        {
            starslvlThree[0].sprite = empty;
            starslvlThree[1].sprite = empty;
            starslvlThree[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlThree") == 1)
        {
            starslvlThree[0].sprite = full;
            starslvlThree[1].sprite = empty;
            starslvlThree[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlThree") == 2)
        {
            starslvlThree[0].sprite = full;
            starslvlThree[1].sprite = full;
            starslvlThree[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlThree") == 3)
        {
            starslvlThree[0].sprite = full;
            starslvlThree[1].sprite = full;
            starslvlThree[2].sprite = full;
        }
    }
    private void starsLvlFour()
    {
        if (PlayerPrefs.GetInt("_starsLvlFour") == 0)
        {
            starslvlFour[0].sprite = empty;
            starslvlFour[1].sprite = empty;
            starslvlFour[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlFour") == 1)
        {
            starslvlFour[0].sprite = full;
            starslvlFour[1].sprite = empty;
            starslvlFour[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlFour") == 2)
        {
            starslvlFour[0].sprite = full;
            starslvlFour[1].sprite = full;
            starslvlFour[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlFour") == 3)
        {
            starslvlFour[0].sprite = full;
            starslvlFour[1].sprite = full;
            starslvlFour[2].sprite = full;
        }
    }
    private void starsLvlFive()
    {
        if (PlayerPrefs.GetInt("_starsLvlFive") == 0)
        {
            starslvlFive[0].sprite = empty;
            starslvlFive[1].sprite = empty;
            starslvlFive[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlFive") == 1)
        {
            starslvlFive[0].sprite = full;
            starslvlFive[1].sprite = empty;
            starslvlFive[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlFive") == 2)
        {
            starslvlFive[0].sprite = full;
            starslvlFive[1].sprite = full;
            starslvlFive[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlFive") == 3)
        {
            starslvlFive[0].sprite = full;
            starslvlFive[1].sprite = full;
            starslvlFive[2].sprite = full;
        }
    }
    private void starsLvlSix()
    {
        if (PlayerPrefs.GetInt("_starsLvlSix") == 0)
        {
            starslvlSix[0].sprite = empty;
            starslvlSix[1].sprite = empty;
            starslvlSix[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlSix") == 1)
        {
            starslvlSix[0].sprite = full;
            starslvlSix[1].sprite = empty;
            starslvlSix[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlSix") == 2)
        {
            starslvlSix[0].sprite = full;
            starslvlSix[1].sprite = full;
            starslvlSix[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlSix") == 3)
        {
            starslvlSix[0].sprite = full;
            starslvlSix[1].sprite = full;
            starslvlSix[2].sprite = full;
        }
    }
    private void starsLvlSeven()
    {
        if (PlayerPrefs.GetInt("_starsLvlSeven") == 0)
        {
            starslvlSeven[0].sprite = empty;
            starslvlSeven[1].sprite = empty;
            starslvlSeven[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlSeven") == 1)
        {
            starslvlSeven[0].sprite = full;
            starslvlSeven[1].sprite = empty;
            starslvlSeven[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlSeven") == 2)
        {
            starslvlSeven[0].sprite = full;
            starslvlSeven[1].sprite = full;
            starslvlSeven[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlSeven") == 3)
        {
            starslvlSeven[0].sprite = full;
            starslvlSeven[1].sprite = full;
            starslvlSeven[2].sprite = full;
        }
    }
    private void starsLvlEight()
    {
        if (PlayerPrefs.GetInt("_starsLvlEight") == 0)
        {
            starslvlEight[0].sprite = empty;
            starslvlEight[1].sprite = empty;
            starslvlEight[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlEight") == 1)
        {
            starslvlEight[0].sprite = full;
            starslvlEight[1].sprite = empty;
            starslvlEight[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlEight") == 2)
        {
            starslvlEight[0].sprite = full;
            starslvlEight[1].sprite = full;
            starslvlEight[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlEight") == 3)
        {
            starslvlEight[0].sprite = full;
            starslvlEight[1].sprite = full;
            starslvlEight[2].sprite = full;
        }
    }
    private void starsLvlNine()
    {
        if (PlayerPrefs.GetInt("_starsLvlNine") == 0)
        {
            starslvlNine[0].sprite = empty;
            starslvlNine[1].sprite = empty;
            starslvlNine[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlNine") == 1)
        {
            starslvlNine[0].sprite = full;
            starslvlNine[1].sprite = empty;
            starslvlNine[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlNine") == 2)
        {
            starslvlNine[0].sprite = full;
            starslvlNine[1].sprite = full;
            starslvlNine[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlNine") == 3)
        {
            starslvlNine[0].sprite = full;
            starslvlNine[1].sprite = full;
            starslvlNine[2].sprite = full;
        }
    }
    private void starsLvlTen()
    {
        if (PlayerPrefs.GetInt("_starsLvlTen") == 0)
        {
            starslvlTen[0].sprite = empty;
            starslvlTen[1].sprite = empty;
            starslvlTen[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlTen") == 1)
        {
            starslvlTen[0].sprite = full;
            starslvlTen[1].sprite = empty;
            starslvlTen[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlTen") == 2)
        {
            starslvlTen[0].sprite = full;
            starslvlTen[1].sprite = full;
            starslvlTen[2].sprite = empty;
        }
        if (PlayerPrefs.GetInt("_starsLvlTen") == 3)
        {
            starslvlTen[0].sprite = full;
            starslvlTen[1].sprite = full;
            starslvlTen[2].sprite = full;
        }
    }
    private void getLockers()
    {
        for (int i = 0; i < lockers.Length; i++)
        {
            if(i>0)
            {
if(levelsStars[i - 1] >0)
            {
                lockers[i].SetActive(false);
            }
            }
            
        }
    }
}
