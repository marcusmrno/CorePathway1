using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float speed = 6f;

    public void characterMovement(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)(//if we are moving
            float turnSmoothTime = 0.1f;

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf
        )    
    }
}
