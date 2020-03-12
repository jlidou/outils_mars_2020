using System.IO;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
namespace DefaultNamespace{
    [UnityEditor.CustomEditor(typeof(MainScript))]
    public class MainScriptEditor : UnityEditor.Editor{
        private MainScript mainScript;
        private string[] listPrefab;
        private int selectPrefabs;
        private void OnEnable() {
            mainScript = (MainScript) target;
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Application.dataPath, "Prefabs"));
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.prefab");
            listPrefab = new string[fileInfo.Length];
            for (int i = 0; i < listPrefab.Length; i++) {
                listPrefab[i] = fileInfo[i].Name;
            }
        }
        public override void OnInspectorGUI() {
            selectPrefabs = EditorGUILayout.Popup(selectPrefabs, listPrefab);
            if (GUILayout.Button("Instancier")) {
                Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/" + listPrefab[selectPrefabs],
                    typeof(GameObject));
                // prefab directement Attention
                // GameObject go = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
                // copy du prefab
                Object go = GameObject.Instantiate(prefab);
            }
        }
    }
}