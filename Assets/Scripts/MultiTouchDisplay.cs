using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultiTouchDisplay : MonoBehaviour
{
    public TextMeshProUGUI multiTouchInfoDisplay;
    private int maxTapCount = 0;
    private string multiTouchInfo;
    private Touch theTouch;
 
    void Update()
    {
		multiTouchInfo = $"Max tap count: { maxTapCount}\n";
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                theTouch = Input.GetTouch(i);
                multiTouchInfo += $"Touch { i}\n-Position { theTouch.position}\n-Tap Count: { theTouch.tapCount}\n-Finger ID: { theTouch.fingerId}\nRadius: { theTouch.radius} ({ ((theTouch.radius / (theTouch.radius + theTouch.radiusVariance)) * 100f).ToString("F1")}%)\n";
                if (theTouch.tapCount > maxTapCount)
                {
                    maxTapCount = theTouch.tapCount;
                }
            }
        }

		multiTouchInfoDisplay.text = multiTouchInfo;
    }
}
