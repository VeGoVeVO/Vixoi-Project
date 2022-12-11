using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance { get; private set; }
    public void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else 
        instance = this;
    }
    public void Load ()
    {

    }
    public void Save ()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data  = new PlayerData_Storage(); 
    }
}
[Serializable]
class PlayerData_Storage
{

}
