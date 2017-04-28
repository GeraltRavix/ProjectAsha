using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    //Vector3 newPosition;
    //public float speed;
    //private Vector3 target;
    //void Start()
    //{
    //    newPosition = transform.position;
    //}
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        RaycastHit hit;
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            newPosition = hit.point;
    //            transform.position = newPosition;
    //            target = transform.position;
    //            //target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);



    //        }
    //        //target.z = transform.position.z;
    //        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    //    }
    //}

    public float speed;
    private Vector3 target;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

}
