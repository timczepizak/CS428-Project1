using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ManScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject placement;
    public GameObject Man;
    public GameObject Button;
    public Animator manAnim;
    private bool flag = false;
    private Transform t;
    public new AudioSource audio;

   

    // Start is called before the first frame update
    void Start()
    {
        t = placement.transform;
        Button = GameObject.Find("NoahButton");
        Button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        manAnim.GetComponent<Animator>();
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (!flag)
        {
            Debug.Log("Button Pressed");
            flag = true;
            Instantiate(Man,t);
            manAnim.Play("Man");
            audio.Play();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        manAnim.Play("none");
        
    }

   
}
