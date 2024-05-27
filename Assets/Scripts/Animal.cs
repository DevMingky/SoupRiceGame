using UnityEngine;

public class Animal
{
	public Animal(string _name,int _atk,int _maxHp,int _nowHp)
	{
		name = _name;
		atk = _atk;
		maxHp = _maxHp;
		nowHp = _nowHp;
	}


	public string name;
	public int maxHp;
	public int nowHp;
	public int atk;
}
