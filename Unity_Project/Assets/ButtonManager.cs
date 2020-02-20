using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonManager : MonoBehaviour, IVirtualButtonEventHandler
{
    public VirtualButtonBehaviour   btn;
    public GameObject               popupObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Button started");

        btn = GetComponent<VirtualButtonBehaviour>();
        btn.RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        popupObject.SetActive(false);
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
        popupObject.SetActive(true);
    }
}
