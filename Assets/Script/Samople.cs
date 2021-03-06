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

    void Hairetu()
    {
        // ■配列型変数宣言
        // 要素型[] 変数名;
        //int[] iAry;

        // ■配列の生成
        // new 要素型[要素数];
        //iAry = new int[3]; // 配列生成と変数への保存

        // 配列要素へのアクセス
        //iAry[0] = 10;
        //iAry[1] = 20;
        //iAry[2] = 30;

        //Debug.Log($"iAry[0]={iAry[0]}");
        //Debug.Log($"iAry[1]={iAry[1]}");
        //Debug.Log($"iAry[2]={iAry[2]}");

        // ■配列初期化子
        // 配列も変数と文法的には同じ宣言と同時に初期化できる。
        // 配列を作成すると同時に要素を設定できる。
        // new 要素型[要素数] { 要素1, 要素2, 要素3, ... }
        // var iAry = new int[3] { 10, 20, 30 };

        // 初期値から要素数と型を推論できる場合
        // new の後の型と要素数も省略可能。
        var iAry = new[] { 10, 20, 30, 40, 50 };

        // Lengh プロパティ、配列の要素数を取得する
        Debug.Log($"iAry.Length={iAry.Length}");

        // for 文による配列アクセス
        for (var i = 0; i < iAry.Length; i++)
        {
            Debug.Log($"iAry[{i}]={iAry[i]}");
        }

        // foreach 文による配列処理
        foreach (var e in iAry)
        {
            Debug.Log($"e={e}");
        }
    }
}
