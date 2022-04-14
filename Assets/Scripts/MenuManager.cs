using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public string nickname;
    public string loadedName;
    public int loadedPoints;
    public int loadedId;

    private static MenuManager _instance;

    public static MenuManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("Instance is null");

            return _instance;
        }
        set => _instance = value;
    }

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        DontDestroyOnLoad(gameObject);

    }

}
