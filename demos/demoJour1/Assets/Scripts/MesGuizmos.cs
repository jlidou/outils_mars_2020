
    using UnityEditor;
    using UnityEngine;
    public class MesGuizmos{
        
        [DrawGizmo(GizmoType.Active | GizmoType.Selected)]
        public static void DraMyGuismo(GizmosScript script, GizmoType gizmoType) {
            Gizmos.color = Color.cyan;
            Gizmos.DrawSphere(script.transform.position, 3);
        }
    }