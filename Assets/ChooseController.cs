using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChooseController : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public Controller controller;
    Dictionary<string, InputDevice> controllers = new Dictionary<string, InputDevice>();

    void Start()
    {
        int number = 1;
        controllers.Add("None", null);
        controllers.Add("Keyboard", Keyboard.current);
        foreach (Gamepad gamepad in Gamepad.all)
        {
            controllers.Add($"{gamepad.displayName} {number}", gamepad);
            number++;
        }
        dropdown.AddOptions(new List<string>(controllers.Keys));
    }

    public void OnChoose(int index)
    {
        controller.device = controllers[dropdown.options[index].text];
    }
}
