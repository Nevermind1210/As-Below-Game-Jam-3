using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleToFile : MonoBehaviour
{
    private string fileName = "";
    
    private void OnEnable() => Application.logMessageReceived += Log;

    private void OnDisable() => Application.logMessageReceived -= Log;

    public void Log(string logString, string stackTrace, LogType type)
    {
        if (fileName == "")
        {
            string path = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop) + "/Unity_Logs";
            System.IO.Directory.CreateDirectory(path);
            string formattedDate = DateTime.Now.ToString();
            fileName = path + "/log- " + formattedDate + ".txt";
        }

        string formattedLogString = "[" + DateTime.Now + "]" + logString;
        
        try
        {
            System.IO.File.AppendAllText(fileName, formattedLogString + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
