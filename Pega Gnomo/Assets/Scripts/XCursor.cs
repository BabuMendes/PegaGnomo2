using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XCursor : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D cursorTex;
    void Start()
    {
        Cursor.SetCursor(cursorTex, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
