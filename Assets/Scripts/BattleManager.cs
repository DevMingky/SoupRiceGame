using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI playerHp;
	[SerializeField] TextMeshProUGUI enemyHp;
	[SerializeField] GameObject HuntButton;
	[SerializeField] TextMeshProUGUI explainText;

	public Animal chicken = new Animal("��",1,10,10);
	public Animal pig = new Animal("����",10, 50, 50);
	public Animal cow = new Animal("��",20, 100, 100);
	List<Animal> animals = new List<Animal>();

	int index;
	[SerializeField] GameObject LoseBattle;

	//hunt ~~ Button�� �ֱ�
	[SerializeField] GameObject ChickenBattle;
	[SerializeField] GameObject PigBattle;
	[SerializeField] GameObject CowBattle;

	List<GameObject> BattleAnimal=new List<GameObject>();
	public void ChangeIndex(int _index)
	{
		index = _index;
		BattleAnimal[index].SetActive(true);
	}


	[SerializeField] GameObject canvas;
	[SerializeField] GameObject battle;
	[SerializeField] GameObject HuntChoice;
	[SerializeField] GameObject DontHaveHp;
	public void Battle()
	{
		if(Player.instance.nowHp>0)
		{
			canvas.SetActive(false);
			battle.SetActive(true);
			HuntChoice.SetActive(false);
			animals[index].nowHp=animals[index].maxHp;
			playerHp.text = "�� ü��: "+Player.instance.nowHp.ToString();
			enemyHp.text = "���� ü��: " + animals[index].nowHp.ToString();
		}
		else
		{
			DontHaveHp.SetActive(true);
		}
	}

	public void OnClickMyExplain()
	{
		EnemyExplain();
	}

	[SerializeField] TextMeshProUGUI enemyExplain;
	public void EnemyExplain()
	{
		enemyExplain.text = animals[index].name + "���� " + animals[index].atk + "�� ���ظ� �Ծ����ϴ�";
		Player.instance.nowHp -= animals[index].atk;
		playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
		enemyHp.text = "���� ü��: " + animals[index].nowHp.ToString();
		if(animals[index].nowHp<=0)
		{
			WinBattle();
		}
		else if(Player.instance.nowHp<=0)
		{
			LoseBattle.SetActive(true);
		}
	}

	public void NomalAtk()
	{
		animals[index].nowHp -= Player.instance.nowWeapon.atk;
		HuntButton.SetActive(false);
		explainText.gameObject.SetActive(true);
		explainText.text = animals[index].name + "���� " + Player.instance.nowWeapon.atk + "�� ���ظ� �������ϴ�";
		playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
		enemyHp.text = "���� ü��: " + animals[index].nowHp.ToString();
		if (animals[index].nowHp <= 0)
		{
			WinBattle();
		}
	}

	public void SpotAtk()
	{
		int temp = Random.Range(0, 2);
		if(temp==0)
		{
			animals[index].nowHp -= Player.instance.nowWeapon.atk*2;
			HuntButton.SetActive(false);
			explainText.gameObject.SetActive(true);
			explainText.text = animals[index].name + "���� " + Player.instance.nowWeapon.atk*2 + "�� ���ظ� �������ϴ�";
			playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
			enemyHp.text = "���� ü��: " + animals[index].nowHp.ToString();
			if (animals[index].nowHp <= 0)
			{
				WinBattle();
			}
			else if (Player.instance.nowHp <= 0)
			{
				LoseBattle.SetActive(true);
			}
		}
		else
		{
			explainText.gameObject.SetActive(true);
			HuntButton.SetActive(false);
			explainText.text = animals[index].name + "���� ������ ���߽�Ű�����߽��ϴ�.";
			playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
			enemyHp.text = "���� ü��: " + animals[index].nowHp.ToString();
			if (animals[index].nowHp <= 0)
			{
				WinBattle();
			}
			else if (Player.instance.nowHp <= 0)
			{
				LoseBattle.SetActive(true);
			}
		}
	}

	[SerializeField] GameObject DontHavePotion;
	[SerializeField] GameObject potionBack;
 	public void Potion(int index)
	{
		if (index == 0)
		{
			if (GameManager.instance.smallPotion.count > 0)
			{
			if(Player.instance.nowHp+ GameManager.instance.smallPotion.healAmount>=Player.instance.maxHp)
			{
					Player.instance.nowHp = Player.instance.maxHp;
			}
			else
			{
				Player.instance.nowHp += GameManager.instance.smallPotion.healAmount;
			}
				GameManager.instance.smallPotion.count--;
				explainText.gameObject.SetActive(true);
				explainText.text = GameManager.instance.smallPotion.healAmount.ToString() + "��ŭ ü���� ȸ���Ͽ����ϴ�";
				playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
				DontHavePotion.SetActive(false);
				potionBack.SetActive(false);
			}
			else
			{
				DontHavePotion.SetActive(true);
			}
		}
		else if (index == 1)
		{
			if (GameManager.instance.middlePotion.count > 0)
			{
				if (Player.instance.nowHp + GameManager.instance.middlePotion.healAmount >= Player.instance.maxHp)
				{
					Player.instance.nowHp = Player.instance.maxHp;
				}
				else
				{
					Player.instance.nowHp += GameManager.instance.middlePotion.healAmount;
				}
				GameManager.instance.middlePotion.count--;
				explainText.gameObject.SetActive(true);
				explainText.text = GameManager.instance.middlePotion.healAmount.ToString() + "��ŭ ü���� ȸ���Ͽ����ϴ�";
				playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
				DontHavePotion.SetActive(false);
				potionBack.SetActive(false);
			}
			else
			{
				DontHavePotion.SetActive(true);
			}
		}
		else if (index == 2)
		{
			if (GameManager.instance.bigPotion.count > 0)
			{
				if (Player.instance.nowHp + GameManager.instance.bigPotion.healAmount >= Player.instance.maxHp)
				{
					Player.instance.nowHp = Player.instance.maxHp;
				}
				else
				{
					Player.instance.nowHp += GameManager.instance.bigPotion.healAmount;
				}
				GameManager.instance.bigPotion.count--;
				explainText.gameObject.SetActive(true);
				explainText.text = GameManager.instance.bigPotion.healAmount.ToString() + "��ŭ ü���� ȸ���Ͽ����ϴ�";
				playerHp.text = "�� ü��: " + Player.instance.nowHp.ToString();
				DontHavePotion.SetActive(false);
				potionBack.SetActive(false);
			}
			else
			{
				DontHavePotion.SetActive(true);
			}
		}
	}

	[SerializeField] GameObject winBattle;
 	[SerializeField] TextMeshProUGUI gogiText;
	[SerializeField] TextMeshProUGUI nowExplain;
	void WinBattle()
	{
		winBattle.SetActive(true);
		TimeManager.instance.hour++;
		gogiText.text = animals[index].name+"��⸦ "+(1 + Player.instance.nowWeapon.drop).ToString()+"�� ȹ���Ͽ����ϴ�";
		if(index==0)
		{
			GameManager.instance.chicken.count += (1 + Player.instance.nowWeapon.drop);
			nowExplain.text = "���� "+animals[index].name +"����� ����:"+GameManager.instance.chicken.count.ToString();
		}
		else if(index==1)
		{
			GameManager.instance.pork.count += (1 + Player.instance.nowWeapon.drop);
			nowExplain.text = "���� " + animals[index].name + "����� ����:" + GameManager.instance.pork.count.ToString();
		}
		else if(index==2)
		{
			GameManager.instance.beef.count += (1 + Player.instance.nowWeapon.drop);
			nowExplain.text = "���� " + animals[index].name + "����� ����:" + GameManager.instance.beef.count.ToString();
		}
	}

	public void OnClickExit()
	{
		TimeManager.instance.hour++;
	}

	private void Awake()
	{
		animals.Add(chicken);
		animals.Add(pig);
		animals.Add(cow);
		BattleAnimal.Add(ChickenBattle);
		BattleAnimal.Add(PigBattle);
		BattleAnimal.Add(CowBattle);
	}

}
