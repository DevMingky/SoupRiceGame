using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager instance;
    //무기
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

        weapon[0].name = "맨손(공격력:1 고기획득량+0)";
        weapon[1].name = "녹슨 일반 도살용 칼(공격력:10 고기획득량+1)";
        weapon[2].name = "녹슬지않은 일반 도살용 칼(공격력:15 고기획득량+2)";
        weapon[3].name = "녹슨 장인의 도살용 칼(공격력:20 고기획득량+3)";
        weapon[4].name = "녹슬지않은 장인의 도살용 칼(공격력:30 고기획득량+4)";
        weapon[5].name = "최고급 장인의 도살용 칼(공격력:50 고기획득량+5)";

        weapon[0].index = 0;
        weapon[1].index = 1;
        weapon[2].index = 2;
        weapon[3].index = 3;
        weapon[4].index = 4;
        weapon[5].index = 5;

        instance = this;
    }

}
