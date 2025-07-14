using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] Animator anicon_MushroomMan;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �Է�
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // �̵�
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // ȸ��
        // �Է°�(moveDirection)�� 0�� �ƴ� ��쿡�� �����̴� ������ �Ǵ��Ѵ�.
        // moveDirection�� 0�϶� = Idle �ִϸ��̼�
        // moveDirection�� 0�� �ƴҶ� = Walk �ִϸ��̼�
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }

        //�ִϸ�����
        bool iswalk = 0 < moveDirection.magnitude;
        anicon_MushroomMan.SetBool("ISWALK", iswalk);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("����!");
            anicon_MushroomMan.SetTrigger("ISATTACK");
        }
    }
}