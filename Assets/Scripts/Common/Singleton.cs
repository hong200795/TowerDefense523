using UnityEngine;
using System.Collections;

public abstract class Singleton<T> where T : class, new()
{
    protected static T s_instance = null;
    public static T Instance
    {
        get
        {
            if (s_instance == null)
                s_instance = new T();
            return s_instance;
        }
    }


    public static bool HasInstance 
    { 
        get { return (s_instance != null); } 
    }

    public static void ResetInstance()
    {
        s_instance = null;
    }
}
