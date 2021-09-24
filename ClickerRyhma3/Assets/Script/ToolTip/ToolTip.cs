using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolTip : MonoBehaviour
{
    public TextMeshProUGUI contentField;

    public LayoutElement layoutElement;

    public int characterWrapLimit;



    private void Awake()
    {

    }

    public void SetText(string content = "")
    {
        if (string.IsNullOrEmpty(content))
        {
            contentField.gameObject.SetActive(false);
        }
        else
        {
            contentField.gameObject.SetActive(true);
            contentField.text = content;
        }

        int contentLength = contentField.text.Length;

        layoutElement.enabled = (contentLength > characterWrapLimit) ? true : false;
    }

    private void Update()
    {
        Vector2 position = Input.mousePosition;

        transform.position = position;
    }


}   
