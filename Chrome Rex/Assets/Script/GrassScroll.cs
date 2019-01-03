using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScroll : MonoBehaviour {

    public float Speed = 0.2f;
    private MeshRenderer render;
    private Vector2 offsetDefault;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
        offsetDefault = render.sharedMaterial.GetTextureOffset("_MainTex");
    }


    void Update()
    {
        float x = Mathf.Repeat(Time.time * Speed, 1);
        Vector2 newOffset = new Vector2(x, offsetDefault.y);
        render.sharedMaterial.SetTextureOffset("_MainTex", newOffset);
    }
}
