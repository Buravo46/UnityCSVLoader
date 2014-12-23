using UnityEngine;
using System.Collections;

/*===============================================================*/
/**
* メインクラス
* 2014年12月23日 Buravo
*/
public class Main : MonoBehaviour 
{
    /*===============================================================*/
    /**
    * @brief 初期化
    */
    void Awake () 
    {
        // ローダーの生成.
        CSVLoader loader = new CSVLoader();
        // CSVを読み込み,CSVのデータテーブルを生成.
        CSVTable csvTable = loader.LoadCSV("CSV/CSVExample");
        foreach (CSVRecord record in csvTable.Records)
        {
            foreach (string header in csvTable.Headers)
            {
                Debug.Log(header + ":" + record.GetField(header));
            }
        }
    }
    /*===============================================================*/
}
/*===============================================================*/
