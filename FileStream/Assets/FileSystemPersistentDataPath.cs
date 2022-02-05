using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileSystemPersistentDataPath : FileSystemWindows
{
    private static FileSystemPersistentDataPath persistentInstance;

    public static FileSystemPersistentDataPath PersistentInstance
    {
        get
        { //Lazy Load
            if (persistentInstance == null)
            {
                persistentInstance = new FileSystemPersistentDataPath();
            }
            return persistentInstance;
        }
    }
    public override void SetText(Text UIText, string path)
    {
        UIText.text = Application.persistentDataPath;
    }
}
