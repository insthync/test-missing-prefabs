﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TestEntity : MonoBehaviour
{
    public TestEntity testReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnValidate()
    {
#if UNITY_EDITOR
        Debug.Log("[" + name + "]#type1 OnValidate()");
        EditorUtility.SetDirty(gameObject);
#endif
    }
}
