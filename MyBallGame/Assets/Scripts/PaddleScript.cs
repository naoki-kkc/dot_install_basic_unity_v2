using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour

{
    // Unity側から書き換え可能になるようにprivateからpublicへ変更
    //private float speed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // 外部から値が与えられた後でStartが呼ばれる動きをしているので、コメントアウトえ
        //speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // キー入力を監視し、パドルを動かす
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed , 0f, 0f);
        //Debug.Log(transform.position.x);
    }
}
