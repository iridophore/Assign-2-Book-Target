using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSequencer : MonoBehaviour
{
    private int             curIndex;
    public GameObject       txtParent;
    public GameObject[]     txtObjList;


    // Start is called before the first frame update
    void Start()
    {
        curIndex = -2;

        Debug.Log("Number of txt objects = " + txtObjList.Length.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    private void HideAllObjects()
    {
        for (int i = 0; i < txtObjList.Length; i++)
        {
            if (txtObjList[i] != null)
                txtObjList[i].SetActive(false);
        }
    }

    public void DecTextObject()
    {
        Debug.Log("Decrement text object");
        HideAllObjects();

        curIndex--;
        if (curIndex < 0)
            curIndex = txtObjList.Length - 1;

        if (txtObjList[curIndex] != null)
            txtObjList[curIndex].SetActive(true);

    }

    public void IncTextObject()
    {
        Debug.Log("Increment text object");
        HideAllObjects();

        curIndex++;
        if (curIndex >= txtObjList.Length)
            curIndex = 0;

        if (txtObjList[curIndex] != null)
            txtObjList[curIndex].SetActive(true);
    }
}
