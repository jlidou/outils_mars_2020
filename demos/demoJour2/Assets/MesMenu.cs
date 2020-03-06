using UnityEditor;
using UnityEngine;
namespace DefaultNamespace{
    public class MesMenu{
        [MenuItem("Menu Test / hello1")]
        public static void UnSuperMenu() {
            Debug.Log("hello 1");
        }
        [MenuItem("Menu Test / hello2 / tata")]
        public static void UnSuperMenu2() {
            Debug.Log("hello 2");
        }
        [MenuItem("Menu Test / hello2 / titi")]
        public static void UnSuperMenu3() {
            Debug.Log("hello 3");
        }
    }
}