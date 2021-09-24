using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTrigger : MonoBehaviour
{
    public Animator anim;
    public GameObject winUI;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (winUI.activeInHierarchy == true)
        {
            //StartCoroutine(waitBeforeStop());

            anim.Play("showScore");


        }
    }
    //IEnumerator waitBeforeStop()
    //{
    //    anim.Play("showScore");
    //    yield return new WaitForSeconds(3);
    //    anim.Play("New State");
       
    //}
}
