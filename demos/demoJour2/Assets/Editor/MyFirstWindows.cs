using System;
using UnityEditor;
using UnityEngine;
public class MyFirstWindows : EditorWindow{
    public static EditorWindow window;
    private Texture _texture;
    [MenuItem("Ma Fenetre / Open")]
    private static void ShowWindow() {
        window = GetWindow<MyFirstWindows>();
        window.titleContent = new GUIContent("Super Fenetre");
        window.Show();
    }
    private void OnEnable() {
        _texture = EditorGUIUtility.whiteTexture;
    }
    private void OnGUI() {
        
        GUI.color = Color.blue;
        GUI.DrawTexture(new Rect(0,0,50,50),_texture );
    }
}