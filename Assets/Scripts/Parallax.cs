using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float backgroundAnimation = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();    
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(backgroundAnimation * Time.deltaTime, 0);
        
    }
}
