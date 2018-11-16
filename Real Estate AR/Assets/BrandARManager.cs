using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrandARManager : MonoBehaviour
{
    public string phoneNumber;
    public string websiteUrl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callButton() {
        Application.OpenURL("tel://" + phoneNumber);
    }

    public void websitelButton() {
        Application.OpenURL(websiteUrl);
    }
}
