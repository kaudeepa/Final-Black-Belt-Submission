using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReturnTimer : MonoBehaviour
{
    [Header("Time before returning to Scene 0")]
    public float timeToReturn = 147f; // 2 minutes and 33 seconds in seconds

    // Start is called before the first frame update
    void Start()
    {
        // Start the countdown to load Scene 0
        Invoke("ReturnToScene0", timeToReturn);
    }

    // Function to load Scene 0
    void ReturnToScene0()
    {
        SceneManager.LoadScene(0);
    }
}