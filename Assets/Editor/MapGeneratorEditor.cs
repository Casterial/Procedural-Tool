using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
/// <summary>
/// Allows the use of the Generate button, or auto update.
/// This also calls other scripts.
/// </summary>
[CustomEditor (typeof (MapGenerator))]

public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        //if "auto Update" is enabled, it will auto update without "Generate"
        if(DrawDefaultInspector())
        {
            if(mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }
        //once "Generate" is pressed it will generate
        if(GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
}
