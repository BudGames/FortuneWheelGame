using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public float RotatePower;
    public float StopPower;

    private Rigidbody2D rbody;
    int inRotate;
    

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    float t;
    private void Update()
    {           
        
        if (rbody.angularVelocity > 0)
        {
            rbody.angularVelocity -= StopPower*Time.deltaTime;

            rbody.angularVelocity =  Mathf.Clamp(rbody.angularVelocity, 0 , 1440);
        }

        if(rbody.angularVelocity == 0 && inRotate == 1) 
        {
            t +=1*Time.deltaTime;
            if(t >= 0.5f)
            {
                GetReward();

                inRotate = 0;
                t = 0;
            }
        }
    }


    public void Rotete() 
    {
        if(inRotate == 0)
        {
            rbody.AddTorque(RotatePower);
            inRotate = 1;
        }
    }



    public void GetReward()
    {
        float rot = transform.eulerAngles.z;

        if (rot > 0+22 && rot <= 45+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,45);
            Win(200);
        }
        else if (rot > 45+22 && rot <= 90+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,90);
            Win(300);
        }
        else if (rot > 90+22 && rot <= 135+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,135);
            Win(400);
        }
        else if (rot > 135+22 && rot <= 180+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,180);
            Win(500);
        }
        else if (rot > 180+22 && rot <= 225+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,225);
            Win(600);
        }
        else if (rot > 225+22 && rot <= 270+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,270);
            Win(700);
        }
        else if (rot > 270+22 && rot <= 315+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,315);
            Win(800);
        }
        else if (rot > 315+22 && rot <= 360+22)
        {
            GetComponent<RectTransform>().eulerAngles = new Vector3(0,0,0);
            Win(100);
        }

    }


    public void Win(int Score)
    {
        print(Score);
    }


}
