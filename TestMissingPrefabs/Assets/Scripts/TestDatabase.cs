using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestDatabase", menuName = "Create/TestDatabase")]
public class TestDatabase : ScriptableObject
{
    public TestEntity[] testEntities;
}
