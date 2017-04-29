using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OnClick : MonoBehaviour
{
    ////private void OnMouseDown()
    ////{
    ////    Destroy(gameObject);
    ////}
    public float Resources = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //print("Test");
            Resources = Resources + 1;
            //print(Resources);
            Destroy(gameObject);
        }

        //Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    // the object identified by hit.transform was clicked
        //    // do whatever you want
        //}
    }

    //Camera Camera;

    //void Start()
    //{
    //    Camera = GetComponent<Camera>();
    //}

    //void Update()
    //{
    //    //Ray2D ray = Camera.ScreenPointToRay(Input.mousePosition);
    //    Ray2D ray = new Ray2D(transform.position, transform.forward);
    //    RaycastHit2D hit;
    //        if (Physics2D.Raycast(ray, out hit))
    //        {
    //            print("test");
    //            // the object identified by hit.transform was clicked
    //            // do whatever you want
    //        }
    //}
}

