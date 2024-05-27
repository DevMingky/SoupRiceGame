using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager instance;
    //����
    public struct Weapon
    {
        public string name;
        public int cost;
        public bool isTrue;
        public int drop;
        public int atk;
        public int index;
    }

    public Weapon []weapon=new Weapon[6];



    
   
    private void Awake()
    {
        weapon[0].cost = 0;
        weapon[1].cost = 100000;
        weapon[2].cost = 500000;
        weapon[3].cost = 1000000;
        weapon[4].cost = 3000000;
        weapon[5].cost = 10000000;

        weapon[0].atk = 1;
        weapon[1].atk = 10;
        weapon[2].atk = 15;
        weapon[3].atk = 20;
        weapon[4].atk = 30;
        weapon[5].atk = 50;

        weapon[0].drop = 0;
        weapon[1].drop = 1;
        weapon[2].drop = 2;
        weapon[3].drop = 3;
        weapon[4].drop = 4;
        weapon[5].drop = 5;

        weapon[0].name = "�Ǽ�(���ݷ�:1 ���ȹ�淮+0)";
        weapon[1].name = "�콼 �Ϲ� ����� Į(���ݷ�:10 ���ȹ�淮+1)";
        weapon[2].name = "�콽������ �Ϲ� ����� Į(���ݷ�:15 ���ȹ�淮+2)";
        weapon[3].name = "�콼 ������ ����� Į(���ݷ�:20 ���ȹ�淮+3)";
        weapon[4].name = "�콽������ ������ ����� Į(���ݷ�:30 ���ȹ�淮+4)";
        weapon[5].name = "�ְ�� ������ ����� Į(���ݷ�:50 ���ȹ�淮+5)";

        weapon[0].index = 0;
        weapon[1].index = 1;
        weapon[2].index = 2;
        weapon[3].index = 3;
        weapon[4].index = 4;
        weapon[5].index = 5;

        instance = this;
    }

}
