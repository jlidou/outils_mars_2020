using System;
using UnityEditor;
using UnityEngine;
namespace DefaultNamespace{
    [CustomPropertyDrawer(typeof(DistanceAttribute))]
    public class DistanceDrawer : PropertyDrawer{
        int nbElement = 2;
        public override void OnGUI(Rect position, SerializedProperty property,
            GUIContent label) {
            DistanceAttribute distanceAttribute = attribute as DistanceAttribute;
            Rect r1 = new Rect(position.x, position.y, position.width, position.height / nbElement);
            Rect r2 = new Rect(position.x, position.y + position.height / nbElement, position.width,
                position.height / nbElement);
            EditorGUI.PropertyField(r1, property);
            if (distanceAttribute.DisplayDistance) {
                EditorGUI.LabelField(r2, DistanceFormat(property.intValue));
            }
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return base.GetPropertyHeight(property, label) * nbElement;
        }
        private String DistanceFormat(int cmTotal) {
            String retour = "";
            int cm = cmTotal % 100;
            int m = 0;
            int km = 0;

            //va avoir des km a afficher
            if (cmTotal / 100 >= 1000) {
                m = (cmTotal / 100) % 1000;
                km = cmTotal / 100000;
                retour = km + "km " + m + "m " + cm + "cm";
            }
            else { //pas de km a afficher
                m = cmTotal / 100;
                retour = m + "m " + cm + "cm";
            }
            return retour;
        }
    }
}