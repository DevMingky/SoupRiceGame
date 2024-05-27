using UnityEngine.UI;
using TMPro;
using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using static GameManager;
using Unity.VisualScripting;

public class KitchenManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI[] SoupRice = new TextMeshProUGUI[10];
	[SerializeField] TextMeshProUGUI[] SoupRice_Count = new TextMeshProUGUI[10];
	[SerializeField] Image[] SoupRice_Image = new Image[10];
	[SerializeField] TextMeshProUGUI[] SoupRice_Cost = new TextMeshProUGUI[10];
	[SerializeField] GameObject[] makeButton=new GameObject[10];
	[SerializeField] GameObject DontHaveIngredient;
	public void OnClickMakeSoup()
	{
		for (int i = 0; i < GameManager.instance.menu.Count; i++)
		{
			SoupRice[i].gameObject.SetActive(true);
			SoupRice[i].text = GameManager.instance.menu[i].name;
			SoupRice_Count[i].gameObject.SetActive(true);
			SoupRice_Count[i].text = GameManager.instance.menu[i].count.ToString();
			SoupRice_Image[i].sprite = GameManager.instance.menu[i].sprite;
			SoupRice_Cost[i].gameObject.SetActive(true);
			SoupRice_Cost[i].text = GameManager.instance.menu[i].cost.ToString();
			makeButton[i].SetActive(true);
		}
	}

	void SetMinus(int index)
	{
		switch(index)
		{
			case 0:
					GameManager.instance.chicken.count--;
				break;
			case 1:
				GameManager.instance.pork.count--;
				break;
			case 2:
				GameManager.instance.beef.count--;
				break;
			case 3:
				GameManager.instance.onion.count--;
				break;
			case 4:
				GameManager.instance.garlic.count--;
				break;
			case 5:
				GameManager.instance.salt.count--;
				break;
			case 6:
				GameManager.instance.chives.count--;
				break;
			case 7:
				GameManager.instance.radish.count--;
				break;
			case 8:
				GameManager.instance.thick.count --;
				break;
			case 9:
				GameManager.instance.greenOnion.count--;
				break;
			case 10:
				GameManager.instance.mint.count--;
				break;
			case 11:
				GameManager.instance.chocolate.count--;
				break;
			case 12:
				GameManager.instance.strawberry.count--;
				break;
			case 13:
				GameManager.instance.banana.count--;
				break;
		}
	}



	int CountChecker(int index)
	{
		if (index == 0)
		{
			return GameManager.instance.chicken.count;
		}
		else if (index == 1)
		{
			return GameManager.instance.pork.count;
		}
		else if (index == 2)
		{
			return GameManager.instance.beef.count;
		}
		else if (index == 3)
		{
			return GameManager.instance.onion.count;
		}
		else if (index == 4)
		{
			return GameManager.instance.garlic.count;
		}
		else if (index == 5)
		{
			return GameManager.instance.salt.count;
		}
		else if (index == 6)
		{
			return GameManager.instance.chives.count;
		}
		else if (index == 7)
		{
			return GameManager.instance.radish.count;
		}
		else if (index == 8)
		{
			return GameManager.instance.thick.count;
		}
		else if (index == 9)
		{
			return GameManager.instance.greenOnion.count;
		}
		else if (index == 10)
		{
			return GameManager.instance.mint.count;
		}
		else if (index == 11)
		{
			return GameManager.instance.chocolate.count;
		}
		else if (index == 12)
		{
			return GameManager.instance.strawberry.count;
		}
		else if (index == 13)
		{
			return GameManager.instance.banana.count;
		}
		return 0;
	}

	public void MakeSoupRice()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[0].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[0].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}


	public void MakeSoupRice1()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[1].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[1].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice2()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[2].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[2].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice3()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[3].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[3].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice4()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[4].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[4].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice5()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[5].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[5].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice6()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[6].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[6].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice7()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[7].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[7].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice8()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[8].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[8].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

	public void MakeSoupRice9()
	{
		int have = 0;
		//0
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[9].ingredient);
		for (int i = 0; i < temp.Count; i++)
		{
			if (CountChecker(temp[i].index) <= 0)
			{
				have = 1;
			}
		}
		if (have == 0)
		{
			for (int i = 0; i < temp.Count; i++)
			{
				SetMinus(temp[i].index);
			}
			//0
			GameManager.instance.menu[9].count++;
			OnClickMakeSoup();
			DontHaveIngredient.SetActive(false);
		}
		else if (have == 1)
		{
			DontHaveIngredient.SetActive(true);
		}
	}

}
