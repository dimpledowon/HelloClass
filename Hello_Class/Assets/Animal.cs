using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // ������ ���� ����
    public string name;
    public string sound;

    //�����Ҹ��� ����ϴ� �޼���
    public void playSound()
    {
        Debug.Log(name + " : " + sound);
    }
}