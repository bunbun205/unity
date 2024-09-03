using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript : MonoBehaviour
{

    public List<GameObject> Options = new List<GameObject>();
    public static List <GameObject> CorrectOptions = new List <GameObject>();

    // Start is called before the first frame update
    public void Start()
    {
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
