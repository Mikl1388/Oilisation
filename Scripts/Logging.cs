using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logging : MonoBehaviour
{
    private void OnEnable()
    {
        Building.onExecuteOperation += ConsoleMessage;
    }
    private void OnDisable()
    {
        Building.onExecuteOperation -= ConsoleMessage;
    }

    private void ConsoleMessage(string text)
    {
        Debug.Log(text);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Log");

        }
    }
}
