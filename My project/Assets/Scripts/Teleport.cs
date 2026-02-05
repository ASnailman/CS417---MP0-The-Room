using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference teleportAction;
    bool isInside = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        teleportAction.action.Enable();
        teleportAction.action.performed += (ctx) => TP();
    }

    void TP()
    {
        if (isInside)
        {
            transform.position = new Vector3(100f, 1f, 0f);
        }
        else
        {
            transform.position = new Vector3(0f, 1f, 0f);
        }
        isInside = !isInside;
    }
}
