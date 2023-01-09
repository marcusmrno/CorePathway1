using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float sens = 1;
    [SerializeField] private bool invertVertical;

    private void Update()
    {
        var deltaMouse = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        Vector2 deltaRotation = deltaMouse * sens;
        deltaRotation.y *= invertVertical ? 1.0f : -1.0f;

        transform.Rotate(Vector3.up, deltaRotation.x);
        transform.Rotate(Vector3.right, deltaRotation.y);
        //transform.localRotation = Quaternion.Euler(pitchAngle, 0.0f, 0.0f);
    }
}