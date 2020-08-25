using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyPresses : MonoBehaviour
{
    [SerializeField] List<KeyCode> desiredKeys;

    public Dictionary<KeyCode, bool> KeysBeingPressed { get; set; }
    public Dictionary<KeyCode, bool> KeysWasPressed { get; set; }
    public Dictionary<KeyCode, bool> KeysWasReleased { get; set; }

    void Awake()
    {
        KeysBeingPressed = new Dictionary<KeyCode, bool>();
        KeysWasPressed = new Dictionary<KeyCode, bool>();
        KeysWasReleased = new Dictionary<KeyCode, bool>();
        foreach (KeyCode key in desiredKeys)
        {
            KeysBeingPressed.Add(key, false);
            KeysWasReleased.Add(key, false);
            KeysWasPressed.Add(key, false);
        }
    }
    void Update()
    {
        SearchForKeysBeingPressed();
        SearchForKeysWasPressed();
        SearchForKeysWasReleased();
    }
    private void SearchForKeysBeingPressed()
    {
        foreach (KeyCode key in desiredKeys)
        {
            KeysBeingPressed[key] = Input.GetKey(key);
        }
    }
    private void SearchForKeysWasPressed()
    {
        foreach (KeyCode key in desiredKeys)
        {
            KeysWasPressed[key] = Input.GetKeyDown(key);
        }
    }
    private void SearchForKeysWasReleased()
    {
        foreach (KeyCode key in desiredKeys)
        {
            KeysWasReleased[key] = Input.GetKeyUp(key);
        }
    }

}
