using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlatformTextDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        string platformInfo = "This Project is ";
#if UNITY_EDITOR
        platformInfo += "in the editor.";
#elif UNITY_WEBGL
        platformInfo += "on the web.";
#else
        platformInfo += "as a build";
#endif
        text.text = platformInfo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
