using System;
using UnityEditor;
using UnityEngine;
namespace DefaultNamespace{
    [UnityEditor.CustomEditor(typeof(RoueScript))]
    public class RoueCustonEditor : UnityEditor.Editor{
        private SerializedProperty nbRayonProp;
        private SerializedProperty couleursRayonProp;
        
        private void OnEnable() {
            nbRayonProp = serializedObject.FindProperty("nbRayon");
            couleursRayonProp = serializedObject.FindProperty("couleursRayon");
            Debug.Log(nbRayonProp.intValue);
            
        }
        public override void OnInspectorGUI() {
            DrawDefaultInspector();
            
            // Color c = serializedObject.FindProperty("couleursRayon.Array.data[0]").colorValue;
            // Debug.Log(c);
            serializedObject.Update();
            EditorGUILayout.PropertyField(nbRayonProp);

            for (int i = 0; i < couleursRayonProp.arraySize; i++) {
                SerializedProperty element = couleursRayonProp.GetArrayElementAtIndex(i);
                Debug.Log(element.colorValue);
                Debug.Log(couleursRayonProp.arrayElementType);
                if (couleursRayonProp.arrayElementType == "int") {
                    EditorGUILayout.PropertyField(element);
                }
                if (couleursRayonProp.arrayElementType == "Color") {
                    // element.colorValue = EditorGUILayout.ColorField(element.colorValue);
                    EditorGUILayout.PropertyField(element);
                }
            }
            
            
            serializedObject.ApplyModifiedProperties();
        }
    }
}