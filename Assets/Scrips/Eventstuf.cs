using UnityEngine;
using UnityEngine.Events;

public class Eventstuf : MonoBehaviour
{
    public UnityEvent onStart, onTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      onStart.Invoke(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger.Invoke();
    }
}
