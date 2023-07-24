using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity�����ƃI�u�W�F�N�g�̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����ƃI�u�W�F�N�g�̈ʒu�iz���W�j�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //Unity�����ƃI�u�W�F�N�g�̈ʒu�iz���W�j�̍������ɂȂ����ۂɃI�u�W�F�N�g��j��
        if (this.difference > 10)
        {
            Destroy(this.gameObject);
        }
    }
}
