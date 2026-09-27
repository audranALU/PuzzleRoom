using UnityEngine;
using UnityEngine.InputSystem;

public class SymbolRotator : MonoBehaviour
{
    public SymbolPuzzle puzzle;

    public Key rotateKey = Key.Digit1;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current[rotateKey].wasPressedThisFrame)
        {
            RotateSymbol();
        }
    }

    public void RotateSymbol()
    {
        transform.Rotate(0f, 0f, 90f);

        puzzle.CheckPuzzle();
    }
}