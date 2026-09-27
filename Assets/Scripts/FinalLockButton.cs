
using UnityEngine;
using UnityEngine.InputSystem;

public class FinalLockButton : MonoBehaviour
{
    public FinalLockPuzzle finalLock;
    public Camera playerCamera;

    public int buttonID;
    public float interactionDistance = 3f;

    void Update()
    {
        if (finalLock == null || playerCamera == null)
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
            if (hit.collider.transform == transform ||
                hit.collider.transform.IsChildOf(transform))
            {
                finalLock.PressButton(buttonID);
            }
        }
    }
}
