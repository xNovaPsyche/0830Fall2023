using UnityEngine;

public class CallbackTest : MonoBehaviour
{
    public void OnParticleSystemStopped()
    {
        Debug.Log("Stop");
    }
}