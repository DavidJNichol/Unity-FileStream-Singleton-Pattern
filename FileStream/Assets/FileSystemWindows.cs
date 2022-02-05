using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class FileSystemWindows : Singleton<FileSystemWindows>
{
    StreamReader reader;
    public override void SetText(Text UIText, string path)
    {
        reader = new StreamReader(path);

        UIText.text = reader.ReadToEnd();
    }
}
