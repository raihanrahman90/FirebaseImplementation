using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataManager : MonoBehaviour
{
    private const string PROGRESS_KEY = "Progress";

    public static UserProgressData Progress;

    public static void Load()
    {
        if (!PlayerPrefs.HasKey(PROGRESS_KEY))
        {
            Progress = new UserProgressData();
            Save();
        }
        else
        {
            string json = PlayerPrefs.GetString(PROGRESS_KEY);
            Progress = JsonUtility.FromJson<UserProgressData>(json);
        }
    }
    public static void Save()
    {
        string json = JsonUtility.ToJson(Progress);
        PlayerPrefs.SetString(PROGRESS_KEY, json);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
