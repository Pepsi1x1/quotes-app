using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[Serializable]
public class Soundbite : ScriptableObject
{
    public string Name;
    public AudioClip Clip;
    public string Source;
    public DateTime SourceDate;
    public string Summary;
    public string Rebuttal;

#if UNITY_EDITOR
    const string soundbitesFolder = "Assets/Soundbites";
    [MenuItem("Assets/Soundbites/New Soundbite")]
    public static void CreateSoundbite()
    {
        
        if (!AssetDatabase.IsValidFolder(soundbitesFolder))
        {
            string[] path = soundbitesFolder.Split('/');
            AssetDatabase.CreateFolder(path[0], path[1]);
        }

        string pName = AssetDatabase.GenerateUniqueAssetPath(string.Format("{0}/New Soundbite.asset", soundbitesFolder));
        var asset = CreateInstance<Soundbite>();
        AssetDatabase.CreateAsset(asset, pName);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    #endif
}

