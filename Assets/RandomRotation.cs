using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

enum directions : int {
    up = 0, 
    down = 180, 
    left = 90, 
    right = 270
}

public class RandomRotation : MonoBehaviour
{
    private GameObject Option1;
    private GameObject Option2;
    // Start is called before the first frame update
    void Start()
    {
        Array Directionvalues = Enum.GetValues (typeof (directions));
        System.Random rnd = new System.Random ();
        directions randomdir1 = (directions) Directionvalues.GetValue (rnd.Next(Directionvalues.Length));
        directions randomdir2= (directions) Directionvalues.GetValue (rnd.Next(Directionvalues.Length));

        while (randomdir1 == randomdir2){
           randomdir2 = (directions) Directionvalues.GetValue (rnd.Next(Directionvalues.Length));
        }

    //    transform.Rotate (0, 90, 0, Space.Self);
        Option1 = transform.parent.GetChild(0).gameObject;
        Option2 = transform.parent.GetChild(1).gameObject;
    
        Option1.transform.Rotate (0, (float)(randomdir1), 0, Space.Self);
        Option2.transform.Rotate (0, (float)(randomdir2), 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
