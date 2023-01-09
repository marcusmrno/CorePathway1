using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        characterMovement();
        cameraControl();
    }
    
    public Transform cam;
    public float speed = 6f;
    float turnSmoothVelocity;
    public CharacterController controller;

    public void characterMovement(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f){//if we are moving
            float turnSmoothTime = 0.1f;

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }


    [SerializeField] private float sens = 1;
    [SerializeField] private bool invertVertical;

    public void cameraControl()
    {
        var deltaMouse = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        Vector2 deltaRotation = deltaMouse * sens;
        deltaRotation.y *= invertVertical ? 1.0f : -1.0f;

        transform.Rotate(Vector3.right, deltaRotation.y);
        transform.Rotate(Vector3.up, deltaRotation.x);
    }
}
