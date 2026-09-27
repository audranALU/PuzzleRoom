
using UnityEngine;
using UnityEngine.InputSystem;

public class PuzzleSwitch : MonoBehaviour
{
    public SwitchPuzzle switchPuzzle;
    public int switchID;

    public Camera playerCamera;
    public float interactionDistance = 3f;

    void Update()
    {
        if (playerCamera == null || switchPuzzle == null)
            return;

        if (Keyboard.current == null ||
            !Keyboard.current.eKey.wasPressedThisFrame)
            return;

        Ray ray = new Ray(
            playerCamera.transform.position,
            playerCamera.transform.forward
        );

        if (Physics.Raycast(ray, out RaycastHit hit,
                            interactionDistance))
        {
            // Activate only when the player looks
            // directly at this switch.
            if (hit.collider.transform == transform ||
                hit.collider.transform.IsChildOf(transform))
            {
                switchPuzzle.ActivateSwitch(switchID);
            }
        }
    }
}
