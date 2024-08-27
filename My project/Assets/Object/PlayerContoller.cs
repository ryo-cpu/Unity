﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2D;
    float junpForce = 680.0f;
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        }

            this.rigidbody2D.AddForce(transform.up*this.junpForce);
            int Key = 0;
            if(Input.GetKeyDown(KeyCode.LeftShift)) 
            { Key = -1; }    
            if(Input.GetKeyDown(KeyCode.RightShift)) 
            { Key = 1; }
        if (transform.position.y < -10||transform.position.x<-3||transform.position.x>3)
        {
            ScreenManager.LoadScenes("GameScrenes");
        }
        else if(transform.position.y>17)
        {
            this.transform.position=new Vector3(transform.position.x,17,transform.position.z);
        }
    }
}
