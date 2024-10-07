using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistenceManager : MonoBehaviour
{
    private GameData gameData;
    public static DataPersistenceManager Instance { get; private set; }
    private void Awake ()
    { if (Instance != null)
        { Debug.LogError("Found more than one Data Persistence Manager in the scene.");
        }
    Instance = this;
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }
    public void LoadGame()
    {
        //load any saved data from file using data handler
        //if no data to load, initialize to new game
        if (this.gameData == null)
        {
            Debug.Log("No Save Data Found. Initializing data to defaults.");
        }
    }
    public void SaveGame()
    {

    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
