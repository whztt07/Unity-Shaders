﻿using UnityEngine;
using UnityEngine.Rendering;

public static class DrawingHelper 
{
    public static GameObject DrawLine(Vector3 start, Vector3 end, Color color, float width = 0.01f, bool destroy = false, float delay = 0)
    {
        GameObject line = new GameObject();
        line.transform.position = start;
        line.AddComponent<LineRenderer>();
        LineRenderer lr = line.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.startColor = color;
        lr.endColor = color;
        lr.startWidth = width;
        lr.endWidth = width;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        lr.shadowCastingMode = ShadowCastingMode.Off;
        lr.receiveShadows = false;
        if (destroy)
        {
            GameObject.Destroy(line, delay);
        }
        return line;
    }
}