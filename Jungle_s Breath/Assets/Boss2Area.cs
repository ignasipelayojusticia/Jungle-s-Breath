﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Area : MonoBehaviour {


    public GameObject actualCamera;
    public GameObject mainCamera;
    public GameObject bossCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            GameObject.Find("Player").GetComponent<CameraAproach>().camera1 = actualCamera;
            GameObject.Find("Player").GetComponent<CameraAproach>().camera2 = bossCamera;

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            GameObject.Find("Player").GetComponent<CameraAproach>().camera1 = actualCamera;
            GameObject.Find("Player").GetComponent<CameraAproach>().camera2 = mainCamera;
        }
    }

}
