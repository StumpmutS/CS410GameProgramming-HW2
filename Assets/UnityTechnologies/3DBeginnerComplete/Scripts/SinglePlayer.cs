using UnityEngine;
using UnityEngine.Events;

public class SinglePlayer : MonoBehaviour
{
    private bool _played;
    
    public UnityEvent OnPlayed = new();
    
    public void Play()
    {
        if (_played) return;
        _played = true;
        
        OnPlayed.Invoke();
    }
}