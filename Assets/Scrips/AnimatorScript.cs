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
        //V�lj vad actionen heter i inputsystemet
        if (williamsPlayerAction.FindAction("Move").IsPressed())
        {
            //v�lj relevant Variabel och namn
            williamsAnimator.SetBool("Run", true);
        }
        else
            williamsAnimator.SetBool("Run", false);


//V�lj vad actionen heter i inputsystemet
        if (williamsPlayerAction.FindAction("Jump").IsPressed())
        {
            //v�lj relevant Variabel och namn
            williamsAnimator.SetBool("Jump", true);
        }
        else
            williamsAnimator.SetBool("Jump", false);
    }
}
