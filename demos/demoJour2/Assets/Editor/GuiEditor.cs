using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GuiScript))]
public class GuiEditor : Editor{
    private GuiScript guiScript;
    private int Test;
    private SerializedProperty TestSerialize;
    private void OnEnable() {
        guiScript = (GuiScript) target;
        Test = guiScript.test;
        TestSerialize = serializedObject.FindProperty("Test");
    }
    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        EditorGUILayout.LabelField("Test");
        // EditorGUILayout.PropertyField(TestSerialize);

        serializedObject.ApplyModifiedProperties();
    }

   


}
