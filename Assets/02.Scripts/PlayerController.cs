using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControllerAction playerControllerAction = new PlayerControllerAction();
    // Start is called before the first frame update
    private void Awake()
    {
        playerControllerAction = new PlayerControllerAction();
        playerControllerAction.Enable();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(Cursor.lockState);
        if(Mouse.current != null)
        {
            
            Vector2 mouseMovement = playerControllerAction.Simple.Look.ReadValue<Vector2>() * Time.deltaTime * 5;
            Vector3 eulerAngle = transform.eulerAngles;

            eulerAngle.y += mouseMovement.x * 0.5f;
            eulerAngle.x += mouseMovement.y * 0.5f;

            transform.eulerAngles = eulerAngle;
        }


    }


}
