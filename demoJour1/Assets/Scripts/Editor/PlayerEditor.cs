using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(PlayerScript))]
public class PlayerEditor : Editor{
    private PlayerScript monPLayer;
    public bool isEnable;
    private void OnDestroy() {
        // Debug.Log("OnDestroy");
    }
    private void OnDisable() {
        // Debug.Log("OnDisable");
    }
    private void OnEnable() {
        // Debug.Log("OnEnable");
        isEnable = true;
        monPLayer = target as PlayerScript;
    }
    private void OnValidate() {
        // Debug.Log("OnValidate");
    }
    public override void OnInspectorGUI() {
        
        Debug.Log("OnInspectorGUI");
        // DrawDefaultInspector(); //garder comportement par default
        EditorGUILayout.LabelField("hello");
        monPLayer.speed = EditorGUILayout.IntField(monPLayer.speed);
        if (GUILayout.Button("Clique moi")) {
            Debug.Log("J ai cliqué sur le piton");
            isEnable = !isEnable;
        }
        if (GUI.changed)
            EditorUtility.SetDirty(target);
        Rect boxButton =
            GUILayoutUtility.GetRect(EditorGUIUtility.currentViewWidth, EditorGUIUtility.singleLineHeight * 4);
        Rect boxButton2 =
            GUILayoutUtility.GetRect(EditorGUIUtility.currentViewWidth, EditorGUIUtility.singleLineHeight * 4);
        Rect boxButton3 =
            GUILayoutUtility.GetRect(EditorGUIUtility.currentViewWidth, EditorGUIUtility.singleLineHeight * 4);
        GUI.Button(new Rect(0, 0, 100, 100), "Je suis un bouton perdu");
        bool saveEnable = GUI.enabled;
        GUI.enabled = false;
        GUI.Button(boxButton, "Je suis un bouton qui retrouvé son chemin");
        GUI.enabled = isEnable;
        GUI.Button(boxButton2, "Je suis un bouton qui retrouvé son chemin");
        GUI.enabled = saveEnable;
        GUI.Button(boxButton3, "Je suis un bouton qui retrouvé son chemin");
        Rect boxDrop =
            GUILayoutUtility.GetRect(EditorGUIUtility.currentViewWidth, EditorGUIUtility.singleLineHeight * 5);

        GUI.Box(boxDrop,"drop zone");
        
        Event e = Event.current;
        //
        //
        // // if (e.type == EventType.MouseMove) {
        //     Debug.Log("position : " + e.mousePosition);
        // // }

        if (e.type == EventType.DragUpdated) {
            Debug.Log("Update");
            DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
            e.Use();
        }
        if (e.type == EventType.DragPerform) {
            Debug.Log("Perform");
            if (boxDrop.Contains(e.mousePosition)) {
                DragAndDrop.AcceptDrag();
                foreach (var Object in DragAndDrop.objectReferences) {
                    GameObject go = Object as GameObject;
                    if (go != null) {
                        Debug.Log(go.name);
                    }
                }
            }
            e.Use();
        }
       
        

    }
    private void OnSceneGUI() {
        DessinDansLaVue();
    }

    private void DessinDansLaVue() {
        SceneView.currentDrawingSceneView.in2DMode = true;
        Handles.color = Color.green;
        Handles.DrawWireCube(monPLayer.transform.position, new Vector3(4, 4, 4));
        Handles.BeginGUI();
        EditorGUILayout.TextField("Hello");
        GUILayout.Button("Coucou");
        Handles.EndGUI();
        
        Handles.DrawWireCube(monPLayer.transform.position, new Vector3(10,10,10));
        Event e = Event.current;


        // if (e.type == EventType.MouseMove) {
        // Debug.Log("position : " + e.mousePosition);
        // }
    }
}