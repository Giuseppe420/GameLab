using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartMap : MonoBehaviour
{
    private bool inContact = false;
    private UnityPlayerControls playerInput;

    // Update is called once per frame
    void Update()
    {
        if (inContact && playerInput.powerUpAction.ReadValue<float>() == 1)
        {
            SceneManager.LoadScene("[traps]AidanLevel");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inContact = true;
        playerInput = collision.gameObject.GetComponent<UnityPlayerControls>();

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inContact = false;
        playerInput = null;
    }
}
