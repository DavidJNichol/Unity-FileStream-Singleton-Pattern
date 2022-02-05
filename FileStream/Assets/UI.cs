using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Text textLineOne;
    public Text textLineTwo;
    public Text textLineThree;

    FileSystemTextAsset textAssetFileReader;
    FileSystemWindows fileSystemWindows;
    FileSystemPersistentDataPath fileSystemPersistentDataPath;

    // Start is called before the first frame update
    void Start()
    {
        textAssetFileReader = FileSystemTextAsset.Instance;

        fileSystemWindows = FileSystemWindows.Instance;

        fileSystemPersistentDataPath = FileSystemPersistentDataPath.PersistentInstance;

        textAssetFileReader.SetText(textLineOne, "FirstLine");

        fileSystemWindows.SetText(textLineTwo, "Assets/Resources/SecondLine.txt");

        fileSystemPersistentDataPath.SetText(textLineThree, "");
    }
}
