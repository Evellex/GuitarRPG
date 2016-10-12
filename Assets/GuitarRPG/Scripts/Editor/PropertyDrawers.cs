using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomPropertyDrawer(typeof(Chord))]
public class ChordDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        int indent = EditorGUI.indentLevel;
        //EditorGUI.indentLevel = 0;
        Rect contentPosition = EditorGUI.PrefixLabel(position, label);
        contentPosition.width *= 1f / 8f;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("b1"), GUIContent.none);
        contentPosition.x += contentPosition.width;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("b2"), GUIContent.none);
        contentPosition.x += contentPosition.width;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("b3"), GUIContent.none);
        contentPosition.x += contentPosition.width;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("w1"), GUIContent.none);
        contentPosition.x += contentPosition.width;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("w2"), GUIContent.none);
        contentPosition.x += contentPosition.width;
        EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("w3"), GUIContent.none);

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }

}
