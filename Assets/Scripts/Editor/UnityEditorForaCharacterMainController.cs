using UnityEngine;
using UnityEditor;
using StarterAssets;

[CustomEditor(typeof(CharacterMainController))]
public class UnityEditorForCharacterMainController : Editor
{
    public override void OnInspectorGUI()
    {
        //Create Apply Gameplay Settings button under public enum variables
        CharacterMainController character = target as CharacterMainController;
        EditorGUILayout.Space(20);
        Rect lastRect = GUILayoutUtility.GetLastRect();
        Rect buttonRect = new Rect(lastRect.x, lastRect.y + 90 , lastRect.width, EditorGUIUtility.singleLineHeight);
        if (GUI.Button(buttonRect, "Apply Gameplay Settings"))
        {
            character.applyGameplayChangesInspectorButtonPressed();
        }
        //Then, draw default inspector
        DrawDefaultInspector();
    }
}
