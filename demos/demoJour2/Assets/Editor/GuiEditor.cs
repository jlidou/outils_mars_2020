using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GuiScript))]
public class GuiEditor : Editor{
    private GuiScript guiScript;
    private void OnEnable() {
        guiScript = (GuiScript) target;
    }
    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        EditorGUILayout.LabelField("Test");
    }

   


}
