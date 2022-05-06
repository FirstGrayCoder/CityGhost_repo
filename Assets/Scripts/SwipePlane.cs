using UnityEngine.EventSystems;
using UnityEngine;
using System;

public class SwipePlane : MonoBehaviour,  IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private float speed;
    public GameObject plane;
    private Transform thisTrans;
    private int Dir = 1;
    private float angle;
    

    public void Start()
    {
        angle = plane.transform.localRotation.eulerAngles.z;
        Debug.Log("This is ---------Angle Start  " + angle);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        // Vector2 delta = eventData.delta;
        // if (Mathf.Abs(delta.y) > Mathf.Abs(delta.x)) // Plane Up
        // {
        //     if(angle>=0f && angle<25)
        //     {
        //         plane.transform.Rotate(0, 0, 3f * Dir * Time.deltaTime);
        //     }
        // }
        // else 
        // {
        //     if(angle > 25f && angle < -0.1f)
        //     {
        //         plane.transform.Rotate(0, 0, 3f * Dir * Time.deltaTime);
        //     }
        // }
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta;
        if (Mathf.Abs(delta.y) > Mathf.Abs(delta.x))
        {
            if (delta.y > 0)
            {
                plane.transform.Translate(Vector2.up * speed * Time.deltaTime); 
                if(angle > 0 || angle < 11)
                    {
                        plane.transform.Rotate(0, 0, 5f * Dir * Time.deltaTime);
                        angle = plane.transform.localRotation.eulerAngles.z;
                        Debug.Log("This is ---------Angle On Drag " + angle);

                    }
                else plane.transform.Rotate(0, 0, 0);
            }
            else 
            {
                plane.transform.Translate(Vector2.down * speed * Time.deltaTime);
                
               // Debug.Log("----Move Plane Down----");
                if(angle > 11f || angle < 0)
                    {
                         Debug.Log("----Must dicreese angle----");
                        plane.transform.Rotate(0, 0, -5f * Dir * Time.deltaTime);
                        angle = plane.transform.localRotation.eulerAngles.z;
                        Debug.Log("This is ---------Angle Must Dicreese" + angle);
                    }
            }
        }
        else return;
    }
    // public void FixedUpdate()
    // {
    //     if((angle>=0f && angle<25) || (angle>270f && angle<360))
    //     {
    //         plane.transform.Rotate(0, 0, 3f * Dir * Time.deltaTime);
    //     }
    // }

    public void OnEndDrag(PointerEventData eventData)
    {
       

             Debug.Log(" ---This is End Drag-------");

            angle = 0; 
                if (angle >= 15 && angle > 0)
                    {
                        angle = 0;
                    }
            
        
        
    }
}
