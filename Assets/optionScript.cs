using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript : MonoBehaviour
{
    public GameObject Option1;
    public GameObject Option2;

    public static GameObject correctOption;

    private List<GameObject> Options = new List<GameObject>();

    public TMP_Text displayText;
    // Start is called before the first frame update
    void Start()
    {
        Options.Add(Option1);
        Options.Add(Option2);
    
        var rnd = new System.Random();

        correctOption = Options[rnd.Next(0, Options.Count)];

        displayText.text = correctOption.name + " is the correct option";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
