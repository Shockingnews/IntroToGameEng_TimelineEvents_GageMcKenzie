using UnityEngine;
using UnityEngine.Playables;

public class triggerscrpit : MonoBehaviour
{

    public PlayableDirector timeLine;

    void OnTriggerEnter(Collider other)
    {
        timeLine.Play();
        Debug.Log("hi");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
}
