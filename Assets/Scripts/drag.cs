using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    private Vector3 mOffset;


    private float mZCoord;



    void OnMouseDown()

    {


        Rigidbody rb = GetComponent<Rigidbody>();
        mZCoord = Camera.main.WorldToScreenPoint(

            gameObject.transform.position).z;
        

        this.GetComponent<Rigidbody>().AddForce(Vector3.left * 100.0f);
       

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void OnMouseUp()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        rb.constraints = RigidbodyConstraints.None;
    }

    private Vector3 GetMouseAsWorldPoint()

    {

  

        Vector3 mousePoint = Input.mousePosition;



      

        mousePoint.z = mZCoord;




        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }
}
