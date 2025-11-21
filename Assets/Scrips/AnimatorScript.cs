using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorScript : MonoBehaviour
{
    public InputActionAsset williamsPlayerAction;
    public Animator williamsAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Välj vad actionen heter i inputsystemet
        if (williamsPlayerAction.FindAction("").IsPressed())
        {
            //välj relevant Variabel och namn
            williamsAnimator.SetBool("", true);
        }
        else
            williamsAnimator.SetBool("", false);

    }
}
