using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameScript : MonoBehaviour
{
    private bool isFront;

    public void setFront()
    {
        if (!isFront)
        {
            transform.position += new Vector3(0, 0.23f, 0);
            isFront = true;
        }
           
    }

    public void setBack()
    {
        if (isFront)
        {
            transform.position += new Vector3(0, -0.23f, 0);
            isFront = false;
        }
        
    }
}
