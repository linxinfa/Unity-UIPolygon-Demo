using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public Button btn;

    void Start()
    {
        btn.onClick.AddListener(() => 
        {
            Debug.Log("on btn clicked");
        });
    }
}
