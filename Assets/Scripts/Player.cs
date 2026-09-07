using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputAction action;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = action.ReadValue<Vector2>();

        Debug.Log(move);

        Vector2 pos = (Vector2)transform.position + move * 5.0f * Time.deltaTime;

        transform.position = pos;

    }
}
