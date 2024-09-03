using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovementScript : MonoBehaviour
{

    public static GameObject startCanvas;
    public GameObject endCanvas;
    AudioSource source;
    public AudioClip clipLeft;
    public AudioClip clipRight;
    public AudioClip clipUp;
    public AudioClip clipDown;
    public List<GameObject> options;
    public List<GameObject> Waypoints;
    int index = 0;
    public static float speed = 0.0f;
    public static bool clicked1 = false, clicked2 = false, clicked3 = false;
    // Start is called before the first frame update

    public static void move()
    {
        speed = 10.0f;
        startCanvas.SetActive(false);
    }

    public static void restart()
    {

    }

    void Start()
    {
        startCanvas = GameObject.Find("StartCanvas");
        index = 0;
        transform.position = Waypoints[index].transform.position;
        endCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
        Vector3 destination = Waypoints[index].transform.position;
        float distance = Vector3.Distance(transform.position, destination);
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        if (distance <= 0.01)
        {
            index++;
        }

        if (Vector3.Distance(transform.position, options[0].transform.position) <= 10 && !clicked1)
        {
            speed = 0;
            PlayAudio ();
        }

        if (clicked1)
        {
            options[0].transform.position = new Vector3(0, -50, 0);
            speed = 10;
        }

        if (Vector3.Distance(transform.position, options[1].transform.position) <= 10 && !clicked2)
        {
            speed = 0;
            PlayAudio ();

        }

        if (clicked2)
        {
            options[1].transform.position = new Vector3(0, -50, 0);
            speed = 10;
        }

        if (Vector3.Distance(transform.position, options[2].transform.position) <= 10 && !clicked3)
        {
            speed = 0;
            PlayAudio ();

        }

        if (clicked3)
        {
            options[2].transform.position = new Vector3(0, -50, 0);
            speed = 10;
            endCanvas.SetActive(true);
        }


    }

    private void PlayAudio()
    {

        foreach (GameObject option in options)
        {
            switch (option.transform.rotation.y){
                case 0:
                source.PlayOneShot(clipUp, 1.0f);
                break;
            case 180:
                source.PlayOneShot(clipDown, 1.0f);

                break;
            case 90:
                source.PlayOneShot(clipLeft, 1.0f);

                break;
            case 270:
                source.PlayOneShot(clipRight, 1.0f);

                break;
            }

            }
        }
    }
