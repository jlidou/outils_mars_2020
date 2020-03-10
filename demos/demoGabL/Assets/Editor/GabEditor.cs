using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace DefaultNamespace{
    [UnityEditor.CustomEditor(typeof(GabScript))]
    public class GabEditor : UnityEditor.Editor{
        private GabScript gabScript;
        private List<GameObject> _gameObjects;
        private void OnEnable() {
            gabScript = target as GabScript;
            gabScript.nom = "Test";
            _gameObjects =  gabScript.GameObjects;
            // if (_gameObjects == null) {
                _gameObjects = new List<GameObject>();
                
                
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = new Vector3(1, 0, 1);
                GameObject go2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = new Vector3(4, 0, 1);
                _gameObjects.Add(go);
                _gameObjects.Add(go2);
            // }
            
        }
        public override void OnInspectorGUI() {
            gabScript.nom = EditorGUILayout.TextField(gabScript.nom);
            EditorGUILayout.LabelField(gabScript.nom);
            if (GUILayout.Button("hello")) {
                Debug.Log("Gab");
            }
            Event e = Event.current;

            Debug.Log(e.mousePosition);

        }
        private void OnSceneGUI() {
            Handles.color =Color.red;
            Handles.DrawLine(_gameObjects[0].transform.position, _gameObjects[1].transform.position);
        }
    }
}