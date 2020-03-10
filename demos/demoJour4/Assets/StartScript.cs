using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Random = UnityEngine.Random;
public class StartScript : MonoBehaviour{
    private List<GameObject> gameObjects;
    
   private void OnLoadDone(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj) {
        // In a production environment, you should add exception handling to catch scenarios such as a null result.
        GameObject myGameObject = obj.Result;
        gameObjects.Add(GameObject.Instantiate(myGameObject));
    }
    void Start() {
        gameObjects = new List<GameObject>();
        Addressables.LoadAssetAsync<GameObject>("AssetAddress").Completed += OnLoadDone;
    }

    // Update is called once per frame
    void Update() {
    }
}