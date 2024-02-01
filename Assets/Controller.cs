using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Controller")]
public class Controller : ScriptableObject
{
    [NonSerialized] public InputDevice device;
}
