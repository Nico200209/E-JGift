using System.Collections;
using UnityEngine;

public class FadeCanvas : MonoBehaviour
{
    public GameObject uiObject; // The UI object to disable
    public float delayTime = 15f; // Delay time in seconds

    void Start()
    {
        // Start the coroutine to disable the UI object after the delay
        StartCoroutine(DisableUIAfterDelay());
    }

    private IEnumerator DisableUIAfterDelay()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delayTime);

        // Disable the UI object
        if (uiObject != null)
        {
            uiObject.SetActive(false);
        }
    }
}