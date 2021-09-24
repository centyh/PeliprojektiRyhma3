using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipSystem : MonoBehaviour
{
    private static ToolTipSystem current;

    public ToolTip tooltips;

    public void Awake()
    {
        current = this;
    }

    public static void Show(string content = "")
    {
        current.tooltips.SetText(content);
        current.tooltips.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        current.tooltips.gameObject.SetActive(false);
    }
}
