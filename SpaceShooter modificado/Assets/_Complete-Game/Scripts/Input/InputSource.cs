using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSource : MonoBehaviour
{
    public InputManager inputManager;
    public MicrophoneInput microphone;

    private void Update()
    {
        if (microphone.GetAveragedVolume() > 0.01)
            inputManager.Shoot();

        
        //if (Input.GetButton("Fire2"))
        //    inputManager.Shoot();
        if (Input.GetKeyDown(KeyCode.R))
            inputManager.RestartGame();


    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        inputManager.MovePlayer(moveHorizontal, moveVertical);
    }
}
