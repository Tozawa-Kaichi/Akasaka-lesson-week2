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

        // + 演算子で文字列結合
        Debug.Log("x=" + x + ", y=" + y);

        // $ 記号による補間文字列
        Debug.Log($"x={x}, y={y}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
