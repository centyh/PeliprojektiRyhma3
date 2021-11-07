using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D customCursor;

    private Vector2 cursorHotspot;
    
    void Start()
    {
        //cursorHotspot = new Vector2(customCursor.width / 2, customCursor.height / 2);
        //Cursor.SetCursor(customCursor, cursorHotspot, CursorMode.Auto);
        Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    
    void Update()
    {

    }
}
