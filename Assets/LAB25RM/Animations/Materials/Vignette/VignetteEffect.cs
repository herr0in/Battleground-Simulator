﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VignetteEffect : MonoBehaviour
{
    public Material mat;
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, mat);
    }
}
