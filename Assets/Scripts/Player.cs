using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    [HideInInspector]
    public int maxHp;
    [HideInInspector]
    public int nowHp;
    public WeaponManager.Weapon nowWeapon;
    public WeaponManager.Weapon buyWeapon
    {
        get 
        { 
            return buyWeapon; 
        }
        set 
        {
            if(nowWeapon.atk<value.atk)
            {
                nowWeapon = value;
            }
        }
    }


    private void Awake()
    {
        maxHp = 100;
        nowHp = maxHp;
        nowWeapon=WeaponManager.instance.weapon[0];
	    instance = this;
	}
}
