using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadTool
{
    public static string path = Application.persistentDataPath + "/player.datababy";
    // Start is called before the first frame update
    public static void Save(PlayerDatas playerDatas)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, playerDatas);
        stream.Close();
    }

    // Update is called once per frame
    public static PlayerDatas Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerDatas playerDatas = formatter.Deserialize(stream) as PlayerDatas;
            stream.Close();
            return playerDatas;
        }
        else
        {
            return new PlayerDatas();
        }
    }
}
