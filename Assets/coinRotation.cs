
using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class coinRotation : UdonSharpBehaviour
{
    public GameObject dish;
    Boolean flag=false;
    public float rotation = 200;
    float count = 0.0f;

    void OnDrop()
    {
        gameObject.transform.position = dish.transform.position + new Vector3(0, 0.05f, 0);
        this.transform.Rotate(90, 0, 0);
        flag = true;
        rotation = 20;
        count = 0.0f;
        Random r = new Random();
        //int randomValue1 = r.Next(10);
        //int randomValue2 = r.Next(10);
        this.transform.rotation = Quaternion.Euler(90, 0, 0);
    }

    void FixedUpdate()
    {
        if(flag) 
        {
            count+=0.01f;
            this.transform.Rotate(0, 0, rotation);
            rotation -= count;
            if (rotation <= 0)
            {
                flag= false;
            }
        }
    }
}
