using System.Collections;
using System.Collections.Generic;
using CustomEditorUtil;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RectTransform))]
public class SampleRectTransformEditor : UnityProvideEditor
{
    protected override UnityProvideEditorType EditorType { get { return UnityProvideEditorType.RectTransformEditor; } }

    RectTransform Target;
    protected override void OnEnable()
    {
        base.OnEnable();
        Target = (RectTransform) target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Sample"))
        {
            Debug.Log("Click! " + Target.name);
        }
    }
}
