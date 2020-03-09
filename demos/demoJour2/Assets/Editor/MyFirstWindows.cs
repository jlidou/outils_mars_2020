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
        // GUI.color = Color.blue;
        // GUI.DrawTexture(new Rect(0,0,50,50),_texture );
        Color[] colors = {Color.blue, Color.black, Color.cyan, Color.yellow};
        // EditorGUILayout.BeginHorizontal();
        // EditorGUILayout.BeginVertical();
        // for (int colonne = 0; colonne < colors.Length; colonne++) {
        //     EditorGUILayout.BeginHorizontal();
        //     for (int ligne = 0; ligne < 5; ligne++) {
        //         // GUI.color = colors[colonne];
        //         
        //         // GUI.Box(GUIContent.none);
        //         
        //         GUI.DrawTexture(new Rect(0, 0, 50, 50), _texture);
        //     }
        //     EditorGUILayout.EndHorizontal();
        // }
        // EditorGUILayout.EndVertical();
        // EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        {
            EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Hello 1");
            EditorGUILayout.LabelField("Hello 2");
            EditorGUILayout.EndVertical();
        }
        {
            EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Hello 1");
            EditorGUILayout.LabelField("Hello 2");
            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.BeginVertical();
        for (int colonne = 0; colonne < colors.Length; colonne++) {
            EditorGUILayout.BeginHorizontal();
            for (int ligne = 0; ligne < 5; ligne++) {
                GUI.color = colors[colonne];
                GUILayout.Box(GUIContent.none, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();
        toto();
        toto(4, 5, 6);
    }
    public void toto(params int[] hello) {
    }
}