using UnityEditor;
using UnityEngine;
namespace DefaultNamespace{
    [CustomPropertyDrawer(typeof(Roue))]
    public class RoueDrawer : PropertyDrawer{
        private int nbElement = 3;
        
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return EditorGUI.GetPropertyHeight(property, label)*nbElement;
        }
        public override void OnGUI(Rect position, SerializedProperty property,
            GUIContent label) {
            //definir la position de mes composants
            Rect r1 = new Rect(position.x, position.y, position.width, position.height/nbElement);
            Rect r2 = new Rect(position.x, position.y + 1 * position.height / nbElement, position.width, position.height/nbElement);
            Rect r3 = new Rect(position.x, position.y + 2 * position.height / nbElement, position.width, position.height/nbElement);


            
            SerializedProperty rayon = property.FindPropertyRelative("rayon");
            SerializedProperty nom = property.FindPropertyRelative("nom");
            SerializedProperty myPosition = property.FindPropertyRelative("position");

            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.PropertyField(r1, rayon);
            EditorGUI.PropertyField(r2, nom);
            EditorGUI.PropertyField(r3, myPosition);
            EditorGUI.EndProperty();
            


        }
    }
}