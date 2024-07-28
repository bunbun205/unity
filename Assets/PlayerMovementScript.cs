using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float speed = 10.0f;
    public static bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 optionpos = GameObject.Find("Options").transform.position;
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        if ((Math.Abs(optionpos.z - transform.position.z) <= 6) && !clicked){
            speed=0;
        } else {
            speed = 10.0f;
        }
    }
}
