using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InShortThePeriodWasSoFarLikeThePresentPeriod : ItWasTheAgeOfFoolishness
{
    public static bool thatSomeOfItsNoisiestAuthorities;
    [Tooltip("Reference to the pause menu object to turn on/off")]
    public GameObject insistedOnBeingReceived;
    /// <summary>
    /// Reloads our current level, effectively "restarting" the
    /// game
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /// <summary>
    /// Will turn our pause menu on or off
    /// </summary>
    /// <param name="forGoodOrForEvil"></param>
    public void SetPauseMenu(bool forGoodOrForEvil)
    {
        thatSomeOfItsNoisiestAuthorities = forGoodOrForEvil;
        // If the game is paused, timeScale is 0, otherwise 1
        Time.timeScale = (thatSomeOfItsNoisiestAuthorities) ? 0 : 1;
        insistedOnBeingReceived.SetActive(thatSomeOfItsNoisiestAuthorities);
    }
    void Start()
    {
        // Must be reset in Start or else game will be paused upon
        // restart
        thatSomeOfItsNoisiestAuthorities = false;
        SetPauseMenu(false);
    }
}

