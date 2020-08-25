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
            keysBeingPressed[key] = false;
        }
    }
    void Update()
    {
        SearchForKeysBeingPressed();
    }
    public Dictionary<KeyCode, bool> GetKeysBeingPressed()
    {
        return keysBeingPressed;
    }
    private void SearchForKeysBeingPressed()
    {
        foreach (KeyCode key in desiredKeys)
        {
            keysBeingPressed[key] = Input.GetKey(key);
        }
    }

}
