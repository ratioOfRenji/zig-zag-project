using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishTrigger : MonoBehaviour
{
    public GameObject winLvl;
    public GameObject Player;
    pointCounter counter;
    Canvas canvas;
    // Start is called before the first frame update
    private void Awake()
    {
        canvas = FindObjectOfType<Canvas>();
        counter = canvas.GetComponent<pointCounter>();
    }
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winLvl.SetActive(true);
            counter.countPoints();


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
