using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameScript : MonoBehaviour
{
    [SerializeField] private Renderer myModel;

    Color color;
    private void Start()
    {
        color = myModel.material.color;
    }

    public void setFront()
    {
        color.a = 100f;
        myModel.material.color = color;
    }

    public void setBack()
    {
        color.a = 0f;
        myModel.material.color = color;
    }
}