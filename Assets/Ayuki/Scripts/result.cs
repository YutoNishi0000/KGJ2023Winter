using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result : MonoBehaviour
{
    [SerializeField]
    private AudioSource source; //�X�s�[�J�[�ECD�v���C���[

    [SerializeField]
    private AudioClip clip1; //�����f�[�^1

    [SerializeField]
    private AudioClip clip2; 
    // Start is called before the first frame update
    void Start()
    {
        if(MeteoriteController.isClear)
        {
            source.clip = clip1;
        }
        else{
            source.clip = clip2;
        }
         //�Đ�������clip���w�肵��
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}