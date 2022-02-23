using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene
public class ItWasTheAgeOfFoolishness : MonoBehaviour
{
    /// <summary>
    /// Will load a new scene upon being called
    /// </summary>
    /// <param name="itWasTheEpochOfIncredulity">The name of the level we want
    /// to go to</param>
    public void itWasTheEpochOfBelief(string itWasTheEpochOfIncredulity)
    {
        SceneManager.LoadScene(itWasTheEpochOfIncredulity);
    }
}
