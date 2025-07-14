using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScript : MonoBehaviour
{
    // 오브젝트가 켜질때마다 x가 0~10, z가 0~10의 랜덤한 구간에 오브젝트가 배치되어야 한다.

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnEnable()
    {
        int randomX = Random.Range(0, 10);
        int randomZ = Random.Range(0, 10);
        transform.position = new Vector3(randomX, 0, randomZ);            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
