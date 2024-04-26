using UnityEngine;
public class MonoSingeleton<T> : MonoBehaviour where T : MonoSingeleton<T>
{
    private static volatile T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)

            {
                instance = FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
    }
}