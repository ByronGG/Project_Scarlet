using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsMenu : MonoBehaviour
{
    public Toggle fullscreenToggle, vsyncTogggle;

    // Start is called before the first frame update
    void Start()
    {
        fullscreenToggle.isOn = Screen.fullScreen;
        if (QualitySettings.vSyncCount == 0)
        {
            vsyncTogggle.isOn = false;
        } else
        {
            vsyncTogggle.isOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreenToggle.isOn;
        if (vsyncTogggle.isOn)
        {
            QualitySettings.vSyncCount = 1;
        } else
        {
            QualitySettings.vSyncCount = 0;
        }
    }
}
