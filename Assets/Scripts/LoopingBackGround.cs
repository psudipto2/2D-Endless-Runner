using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackGround : MonoBehaviour
{
    public float BackgroundSpeed;
    public Renderer BackgroundRenderer;
    private void Update()
    {
        BackgroundRenderer.material.mainTextureOffset += new Vector2(BackgroundSpeed * Time.deltaTime, 0f);
    }
}
