using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaAnimator : MonoBehaviour
{

    public Renderer render;
    public float lavaSpeed = 0.05f;

    private Material mat;

    private void Start()
    {
        mat = render.material;
    }

    private void Update()
    {
        float offset = Mathf.Sin(Time.time * lavaSpeed) / 50f;
        mat.mainTextureOffset = new Vector2(offset, offset);
    }
}
