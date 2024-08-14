using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public List <GameObject> placements;
    public List <GameObject> Waypoints;
    int index = 0;
    public float speed = 10.0f;
    public static bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        clicked = false;
        transform.position = Waypoints[index].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = Waypoints[index].transform.position;
        float distance = Vector3.Distance(transform.position, destination);
        Vector3 newPos = Vector3.MoveTowards (transform.position, destination, speed*Time.deltaTime);
        transform.position = newPos;
        if (distance <= 0.01){
            index++;
        }
        foreach (GameObject placement in placements) {
            if (Vector3.Distance (transform.position, placement.transform.position) <= 5 && !clicked){
                speed = 0; 
            }
            else speed = 10;
        }

    }
}
