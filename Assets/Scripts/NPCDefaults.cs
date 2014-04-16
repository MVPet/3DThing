using UnityEngine;
using System.Collections;

public class NPCDefaults : MonoBehaviour {
    
    // Just default things for NPCs
    private PlayerController playerController;
    public bool speaking = false;
    public bool playerInRange = false;

    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag(Tags.player).GetComponent<PlayerController>();
    }

    void Update()
    {
        if (speaking)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerController.canDoThings = true;
                speaking = false;
            }
        }
        else if (playerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerController.canDoThings = false;
                speaking = true;
            }
        }
    }

    void OnGUI()
    {
        if (playerInRange && !speaking)
            GUI.Box(new Rect(Screen.width * .4f, Screen.height * .1f, Screen.width * .2f, Screen.height * .1f), "\nPress E to Talk");

        if (speaking)
            GUI.Box(new Rect(Screen.width * .1f, Screen.height * .75f, Screen.width * .7f, Screen.height * .13f), "Hello\n\nPress E to Continue");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tags.player)
            playerInRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == Tags.player)
            playerInRange = false;
    }
}
