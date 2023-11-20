using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public void CreatInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
