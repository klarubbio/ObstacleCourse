using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonBehavior : MonoBehaviour
{
    private float timer = 0;
    private bool gameStarted = false;

    public GameObject player;
    public GameObject finishLine;

    public TextMeshProUGUI buttonText;

    public void OnClick()
    {
        //start the timer
        gameStarted = true;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameStarted)
        {
            // may need to adjust this depending on where things are in your scene
            if (player.transform.position.x > finishLine.transform.position.x)
            {
                gameStarted = false;
                buttonText.text = "Done: " + buttonText.text;
            }
            else
            {
                timer += Time.deltaTime;
                buttonText.text = timer.ToString();
            }
        }
    }
}
