using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TestEntity2 : MonoBehaviour
{
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
        Debug.Log("[" + name + "]#type2 OnValidate()");
        EditorUtility.SetDirty(this);
#endif
    }
}
