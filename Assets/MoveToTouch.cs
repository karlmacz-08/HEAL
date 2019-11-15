using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTouch : MonoBehaviour
{
    
    protected Joystick joystick;
    
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }
    // Update is called once per frame
    void Update()
    {
    
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");;
    //rigidbody.velocity
        var rigidbody = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(joystick.Horizontal + x,
                                        0f,
                                        joystick.Vertical + z);
                                        
        rigidbody.velocity  = movement * 10f;
        
        if(x != 0  && z !=0)
        {
            transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2(x,z) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
