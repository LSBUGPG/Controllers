using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    void Update()
    {
    }

    public void OnMove(InputContext input)
    {
        Vector2 move = input.GetValue<Vector2>();
        Debug.Log($"Move {move}");
    }
}
