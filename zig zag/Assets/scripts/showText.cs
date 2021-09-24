using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class showText : MonoBehaviour
{
    public TextMeshPro dg;
    public TMP_Text _text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string i =pointCounter.points.ToString();
        _text.text = i;
    }
}
