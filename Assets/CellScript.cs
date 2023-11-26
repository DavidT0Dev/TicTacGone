using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
    bool timed;
    float timer; // Seconds before clearing cell
    public int playerId; // 0 for empty cell

    public CellScript(int _playerId = 0, bool _timed = false, float _timer = 0)
    {
        this.playerId = _playerId;
        this.timed = _timed;
        this.timer = _timer;
    }

    // Update is called once per frame
    void Update()
    {
        CheckTimer();
    }

    public void CheckTimer()
    {
        if (!timed) return;

        // Check if the timer has not reached zero
        if (timer > 0)
        {
            // Update the timer using Time.deltaTime
            timer -= Time.deltaTime;

            // Optionally, you can display the timer value
            Debug.Log("Timer: " + timer);
        }
        else
        {
            // Timer has reached zero, perform actions or reset as needed
            Debug.Log("Timer has reached zero!");
            playerId = 0;
        }
    }

    public void MarkCell(int _playerId)
    {
        if (playerId != 0) return;

        playerId = _playerId;
    }
    
}
