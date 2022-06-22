using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveNumber 
{
    public static void SaveNum (PlayerData number)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/numberforalert.saved";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(number);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    internal static void SaveNum()
    {
        throw new NotImplementedException();
    }

    internal static void SaveNum(ButtonPress buttonPress)
    {
        throw new NotImplementedException();
    }

    public static PlayerData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/numberforalert.saved";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }
}
