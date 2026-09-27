
using UnityEngine;
using UnityEngine.InputSystem;

public class HiddenKeyPickup : MonoBehaviour
{
    public Transform player;
    public float pickupDistance = 3f;

    public bool hasKey = false;

    private Renderer[] keyRenderers;
    private Collider[] keyColliders;

    void Start()
    {
        keyRenderers = GetComponentsInChildren<Renderer>();
        keyColliders = GetComponentsInChildren<Collider>();
    }

    void Update()
    {
        if (hasKey || player == null)
            return;

        float distance = Vector3.Distance(
            player.position,
            transform.position
        );

        if (distance <= pickupDistance &&
            Keyboard.current != null &&
            Keyboard.current.eKey.wasPressedThisFrame)
        {
            PickUpKey();
        }
    }

    void PickUpKey()
    {
        hasKey = true;

        foreach (Renderer keyRenderer in keyRenderers)
            keyRenderer.enabled = false;

        foreach (Collider keyCollider in keyColliders)
            keyCollider.enabled = false;

        Debug.Log("Key collected!");
    }
}
