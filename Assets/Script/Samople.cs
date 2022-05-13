using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samople : MonoBehaviour
{
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World",this);
        
        var x = 10;
        var y = 20;

        // + ‰‰Zq‚Å•¶š—ñŒ‹‡
        Debug.Log("x=" + x + ", y=" + y);

        // $ ‹L†‚É‚æ‚é•âŠÔ•¶š—ñ
        Debug.Log($"x={x}, y={y}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
