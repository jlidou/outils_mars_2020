using System.IO;
using Boo.Lang;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
namespace DefaultNamespace{
    [UnityEditor.CustomEditor(typeof(MainScript))]
    public class MainScriptEditor : UnityEditor.Editor{
        private MainScript mainScript;
        private string[] listPrefab;
        private List<GameObject> test;
        private int selectPrefabs;
        private void OnEnable() {
            mainScript = (MainScript) target;
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Application.dataPath, "Prefabs"));
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.prefab");
            listPrefab = new string[fileInfo.Length];
            for (int i = 0; i < listPrefab.Length; i++) {
                listPrefab[i] = fileInfo[i].Name;
            }
            test = new List<GameObject>();
        }
        public override void OnInspectorGUI() {
            selectPrefabs = EditorGUILayout.Popup(selectPrefabs, listPrefab);
            if (GUILayout.Button("Instancier")) {
                Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/" + listPrefab[selectPrefabs],
                    typeof(GameObject));
                // prefab directement Attention
                for (int i = 0; i < 10; i++) {
                    GameObject go = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
                    test.Add(go);
                }
                // GameObject go = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
                // copy du prefab
                // Object go = GameObject.Instantiate(prefab);
            }
        }
    }
}