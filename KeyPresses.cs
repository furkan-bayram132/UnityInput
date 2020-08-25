using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyPresses : MonoBehaviour
{
    [SerializeField] List<KeyCode> desiredKeys;

    private Dictionary<KeyCode, bool> keysBeingPressed = new Dictionary<KeyCode, bool>();
    private Dictionary<KeyCode, bool> keysWasPressed = new Dictionary<KeyCode, bool>();
    private Dictionary<KeyCode, bool> keysWasReleased = new Dictionary<KeyCode, bool>();

    void Awake()
    {
        foreach (KeyCode key in desiredKeys)
        {
            keysBeingPressed.Add(key, false);
            keysWasReleased.Add(key, false);
            keysWasPressed.Add(key, false);
        }
    }
    void Update()
    {
        SearchForKeysBeingPressed();
        SearchForKeysWasPressed();
        SearchForKeysWasReleased();
    }
    public Dictionary<KeyCode, bool> GetKeysBeingPressed()
    {
        return keysBeingPressed;
    }
    public Dictionary<KeyCode, bool> GetKeysWasPressed()
    {
        return keysWasPressed;
    }
    public Dictionary<KeyCode, bool> GetKeysWasReleased()
    {
        return keysWasReleased;
    }
    private void SearchForKeysBeingPressed()
    {
        foreach (KeyCode key in desiredKeys)
        {
            keysBeingPressed[key] = Input.GetKey(key);
        }
    }
    private void SearchForKeysWasPressed()
    {
        foreach (KeyCode key in desiredKeys)
        {
            keysWasPressed[key] = Input.GetKeyDown(key);
        }
    }
    private void SearchForKeysWasReleased()
    {
        foreach (KeyCode key in desiredKeys)
        {
            keysWasReleased[key] = Input.GetKeyUp(key);
        }
    }

}
