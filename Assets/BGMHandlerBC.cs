using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMHandlerBC : MonoBehaviour
{
    public static BGMHandlerBC Instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }   
    }
}
