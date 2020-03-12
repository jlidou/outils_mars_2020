using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace Managers{
    public class JsonManager{
        private static String fileName = "jsonSaveData.json";
        
        
        public static String ToJson<T>(T toStringiFy) {
            return JsonUtility.ToJson(toStringiFy);
        }

        public static String StringListToJSon<T> (List<T> toStringifyList)  {
           JsonListWrapper<T> liste = new JsonListWrapper<T>(toStringifyList);
            return JsonUtility.ToJson(liste);
        }


        public static void SaveToStreamingAsset(String toSave) {
            if (!Directory.Exists(Application.streamingAssetsPath))
                Directory.CreateDirectory(Application.streamingAssetsPath);
            File.WriteAllText(Path.Combine(Application.streamingAssetsPath, fileName), toSave);
        }


        [Serializable]
        public class JsonListWrapper<T>{
            public List<T> list;
            public JsonListWrapper(List<T> list) {
                this.list = list;
            }
        }
    }
}