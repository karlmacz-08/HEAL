using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    public static void SavePlayer(PlayerScript player)
    {
        string path = Application.persistentDataPath + "/player.heal";
        FileStream fs = new FileStream(path, FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        Player data = new Player(player);

        bf.Serialize(fs, data);
        fs.Close();
    }

    public static Player LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.heal";

        if (File.Exists(path))
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            Player data = bf.Deserialize(fs) as Player;
            fs.Close();

            return data;
        }
        else
        {
            return null;
        }
    }
}
