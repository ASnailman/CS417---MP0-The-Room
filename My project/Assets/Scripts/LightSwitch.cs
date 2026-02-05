using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour 
{
    public Light light; 
    public InputActionReference changeColorAction;

    void Start() 
    {
        light = GetComponent<Light>(); 
        changeColorAction.action.Enable();

        changeColorAction.action.performed += (ctx) => 
        {
            light.color = new Color(200f, 100f, 700f); 
        };
    }
}