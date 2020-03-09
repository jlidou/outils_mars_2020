using UnityEditor;
using UnityEngine;
public class DistanceAttribute : PropertyAttribute{
    public bool DisplayDistance;
    public DistanceAttribute(bool displayDistance) {
        DisplayDistance = displayDistance;
    }
}