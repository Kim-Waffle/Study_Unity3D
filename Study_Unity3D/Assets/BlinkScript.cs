using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScript : MonoBehaviour
{
    // ������Ʈ�� ���������� x�� 0~10, z�� 0~10�� ������ ������ ������Ʈ�� ��ġ�Ǿ�� �Ѵ�.

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
