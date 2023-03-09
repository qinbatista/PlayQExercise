using UnityEditor;
using UnityEngine;
using Algorithm;
using System.Collections.Generic;

public class MyWindow : EditorWindow
{
    private Vector2 scrollPosition = Vector2.zero;

    [MenuItem("Window/My Window")]
    public static void ShowWindow()
    {
        GetWindow<MyWindow>("My Window");
    }

    private bool showExtraInformation = false;
    Container container;
    List<string> labels = new List<string>();

    private void OnGUI()
    {
        container = new Container();//generate the container
        if (GUILayout.Button("Add Container"))//if Add container button clicked
        {
            for (int i = 0; i < container.Size; i++)
            {
                labels.Add($"Size:{container.Size},Value:{container.Value},Index:{i+1}");//add labels text to the list
                container.MoveForward(); //move to next node
            }
        }
        if (GUILayout.Button("Clear"))
        {
            labels.Clear(); //clear label list
        }
        // Begin the scroll view
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
        // Iterate over the labels list and display each label
        foreach (string label in labels)
        {
            GUILayout.Label(label);
        }
        // End the scroll view
        EditorGUILayout.EndScrollView();
    }
}
