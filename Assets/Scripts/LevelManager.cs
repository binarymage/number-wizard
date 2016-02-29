using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("LoadLevel requested for: " + name);
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame requested");
    }
}
