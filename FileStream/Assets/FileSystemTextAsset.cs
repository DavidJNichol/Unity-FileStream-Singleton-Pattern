using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FileSystemTextAsset : Singleton<FileSystemTextAsset>
{
    TextAsset textAsset;

    //Private Constructor
    private FileSystemTextAsset()
    {
    }

    public override void SetText(Text UIText, string path)
    {
        textAsset = new TextAsset();
        textAsset = Resources.Load(path) as TextAsset;

        UIText.text = textAsset.text;
    }
}
