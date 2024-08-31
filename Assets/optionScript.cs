using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript : MonoBehaviour
{

    static List<GameObject> Options = new List<GameObject>();
    public static List <GameObject> CorrectOptions = new List <GameObject>();

    // Start is called before the first frame update
    public static void Start()
    {

        Options.Add (GameObject.Find ("OptionA"));
        Options.Add (GameObject.Find ("OptionB"));
        Options.Add (GameObject.Find ("OptionA1"));
        Options.Add (GameObject.Find ("OptionB1"));
        Options.Add (GameObject.Find ("OptionA2"));
        Options.Add (GameObject.Find ("OptionB2"));



    
        var rnd = new System.Random();

        CorrectOptions.Add (Options[rnd.Next(0, 2)]);
        CorrectOptions.Add (Options[rnd.Next(2, 4)]);
        CorrectOptions.Add (Options[rnd.Next(4, 6)]);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
