using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F6))
        {
            TriggerDialogue();
        }
    }
}
