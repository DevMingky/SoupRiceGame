using System.Collections.Generic;
using TMPro;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewMenumanager : MonoBehaviour
{




	/// <summary>
	/// 신메뉴 개발 클릭시
	/// </summary>
    public TMP_InputField soupRiceName;
    List<GameManager.Ingredient> ingredient = new List<GameManager.Ingredient>();
	[SerializeField] GameObject newMenuDevelop;
	[SerializeField] TextMeshProUGUI menuLimit;
	[SerializeField] GameObject newMenuDevelop_ani;
	[SerializeField] Sprite chickenSoup;
	[SerializeField] Sprite pigSoup;
	[SerializeField] Sprite cowSoup;
	[SerializeField] Sprite bananaSoup;
	[SerializeField] Sprite chocolateSoup;
	[SerializeField] Sprite mintSoup;
	[SerializeField] Sprite mintChocolateSoup;
	[SerializeField] Sprite strawberrySoup;

    [SerializeField] GameObject newMenuResult;
    [SerializeField] Image resultImage;
    [SerializeField] TextMeshProUGUI SoupRiceNameText;
    [SerializeField] TextMeshProUGUI SoupRiceCostText;
    public void OnClickNewMenu()
    {
        GameManager.SoupRice temp=new GameManager.SoupRice();
		temp.ingredient_count=ingredient.Count;
		temp.name = soupRiceName.GetComponent<TMP_InputField>().text;
		temp.ingredient = JsonConvert.SerializeObject(ingredient);
		for (int i = 0; i < ingredient.Count; i++)
		{
			temp.cost += ingredient[i].cost;
		}
		temp.cost *= 2;
		if (GameManager.instance.chicken.choice && GameManager.instance.greenOnion.choice && GameManager.instance.salt.choice &&ingredient.Count==3)
		{
			temp.cost =(int)(temp.cost* 1.2f);
		}
		if (GameManager.instance.pork.choice && GameManager.instance.greenOnion.choice && GameManager.instance.chives.choice && GameManager.instance.salt.choice)
		{
			temp.cost = (int)(temp.cost * 1.2f);
		}
		if (GameManager.instance.beef.choice && GameManager.instance.radish.choice && GameManager.instance.salt.choice && GameManager.instance.greenOnion.choice && GameManager.instance.garlic.choice && ingredient.Count == 5)
		{
			temp.cost = (int)(temp.cost * 1.2f);
		}
		if (inMain)
		{
			if (GameManager.instance.menu.Count < 10)
			{
				if(GameManager.instance.banana.choice)
				{
					temp.sprite = bananaSoup;
                    temp.spriteIndex = 6;
                }
				if(GameManager.instance.strawberry.choice)
				{
					temp.sprite = strawberrySoup;
                    temp.spriteIndex = 7;
                }

				if(GameManager.instance.mint.choice || GameManager.instance.chocolate.choice)
				{
					if(GameManager.instance.mint.choice && GameManager.instance.chocolate.choice)
					{
						temp.sprite = mintChocolateSoup;
                        temp.spriteIndex = 3;
                    }
					else if(GameManager.instance.chocolate.choice)
					{
						temp.sprite=chocolateSoup;
                        temp.spriteIndex = 4;
                    }
					else if(GameManager.instance.mint.choice)
					{
						temp.sprite = mintSoup;
                        temp.spriteIndex = 5;
                    }
				}

				if(GameManager.instance.mint.choice==false && GameManager.instance.chocolate.choice==false && GameManager.instance.strawberry.choice==false && GameManager.instance.banana.choice==false)
				{
					if(GameManager.instance.chicken.choice)
					{
						temp.sprite = chickenSoup;
						temp.spriteIndex = 0;
					}
					if(GameManager.instance.beef.choice)
					{
						temp.sprite = cowSoup;
                        temp.spriteIndex = 2;
                    }
					if(GameManager.instance.pork.choice)
					{
						temp.sprite = pigSoup;
                        temp.spriteIndex = 1;
                    }
				}
				TimeManager.instance.hour++;
				SoupRiceCostText.text = "국밥가격: "+temp.cost.ToString();
                SoupRiceNameText.text = "국밥이름: " + temp.name;
                resultImage.sprite=temp.sprite;
                GameManager.instance.menu.Add(temp);
				StartCoroutine(NewMenuDevelopAni());
				newMenuReset();
				newMenuDevelop.SetActive(false);
			}
			else
			{
				menuLimit.text = "신메뉴를 개발할수있는 최대개수에 도달하였습니다.";
				menuLimit.gameObject.SetActive(true);
			}
		}
		else
		{
			menuLimit.text = "메인재료를 선택하지 않았습니다.";
			menuLimit.gameObject.SetActive(true);
		}
	}

	void newMenuReset()
	{
		menuLimit.gameObject.SetActive(false);
		sub1_image.sprite = null;
		sub2_image.sprite = null;
		sub3_image.sprite = null;
		sub4_image.sprite = null;
		sub5_image.sprite = null;
		main_image.sprite = null;
        GameManager.instance.chicken.choice = false;
		GameManager.instance.pork.choice = false;
		GameManager.instance.beef.choice = false;
		GameManager.instance.onion.choice = false;
		GameManager.instance.garlic.choice = false;
		GameManager.instance.salt.choice = false;
		GameManager.instance.chives.choice = false;
		GameManager.instance.radish.choice = false;
		GameManager.instance.thick.choice = false;
		GameManager.instance.greenOnion.choice = false;
		GameManager.instance.mint.choice = false;
		GameManager.instance.chocolate.choice = false;
		GameManager.instance.strawberry.choice = false;
        GameManager.instance.banana.choice = false;
		subCount = 0;
		ingredient.Clear();
		inMain = false;
		soupRiceName.GetComponent<TMP_InputField>().text = "";
	}

	public void OnClickNewMenuExit()
	{
		newMenuReset();
		newMenuDevelop.SetActive(false);
	}


	IEnumerator NewMenuDevelopAni()
	{
		newMenuDevelop_ani.SetActive(true);
		yield return new WaitForSeconds(3f);
		newMenuDevelop_ani.SetActive(false);
        newMenuResult.SetActive(true);

    }



	public GameObject mainChoice;
	//메인재료가 들어가있는지 확인하는 변수
	bool inMain;
	public void OnClickMain_Chicken()
	{
		if (GameManager.instance.chicken.choice == false && GameManager.instance.pork.choice == false && GameManager.instance.beef.choice == false)
		{
			inMain = true;
			ingredient.Add(GameManager.instance.chicken);
			main_image.sprite = chicken_image;
            GameManager.instance.chicken.choice = true;
			mainChoice.SetActive(false);
		}
	}
	public void OnClickMain_Pig()
	{
		if (GameManager.instance.chicken.choice == false && GameManager.instance.pork.choice == false && GameManager.instance.beef.choice == false)
		{
			inMain = true;
			main_image.sprite = pork_image;
            ingredient.Add(GameManager.instance.pork);
            GameManager.instance.pork.choice = true;
            mainChoice.SetActive(false);
        }
	}
	public void OnClickMain_Cow()
	{
		if (GameManager.instance.chicken.choice == false && GameManager.instance.pork.choice == false && GameManager.instance.beef.choice == false)
		{
			inMain = true;
			main_image.sprite = beef_image;
            ingredient.Add(GameManager.instance.beef);
            GameManager.instance.beef.choice=true;
            mainChoice.SetActive(false);
        }
	}

	public GameObject subChoice1;
	public GameObject subChoice2;
	public GameObject subChoice3;
	public GameObject subChoice4;
	public GameObject subChoice5;
	int subCount=0;
	public void OnClickSub1()
	{
		if(subCount==0)
		{
			subChoice1.SetActive(true);
		}
	}
	public void OnClickSub2()
	{
		if (subCount == 1)
		{
			subChoice2.SetActive(true);
		}
	}
	public void OnClickSub3()
	{
		if (subCount == 2)
		{
			subChoice3.SetActive(true);
		}
	}
	public void OnClickSub4()
	{
		if (subCount == 3)
		{
			subChoice4.SetActive(true);
		}
	}
	public void OnClickSub5()
	{
		if (subCount == 4)
		{
			subChoice5.SetActive(true);
		}
	}

	public Image main_image;
	public Image sub1_image;
	public Image sub2_image;
	public Image sub3_image;
	public Image sub4_image;
	public Image sub5_image;
	public Sprite chicken_image;
	public Sprite pork_image;
	public Sprite beef_image;
	public Sprite onion_image;
	public Sprite garlic_image;
	public Sprite salt_image;
	public Sprite chives_image;
	public Sprite radish_image;
	public Sprite thick_image;
	public Sprite greenOnion_image;
	public Sprite mint_image;
	public Sprite chocolate_image;
	public Sprite strawberry_image;
	public Sprite banana_image;
	/// <summary>
	/// OnClcikSub1
	/// </summary>
	/// 




	public void OnClickSub1_onion()
    {
		if(GameManager.instance.onion.choice==false)
		{
			ingredient.Add(GameManager.instance.onion);
			subCount++;
			sub1_image.sprite = onion_image;
            GameManager.instance.onion.choice = true;
			subChoice1.SetActive(false);
        }

	}
	public void OnClickSub1_garlic()
	{
		if (GameManager.instance.garlic.choice == false)
		{
			ingredient.Add(GameManager.instance.garlic);
			subCount++;
			sub1_image.sprite = garlic_image;
            GameManager.instance.garlic.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_salt()
	{
		if (GameManager.instance.salt.choice == false)
		{
			ingredient.Add(GameManager.instance.salt);
			subCount++;
			sub1_image.sprite = salt_image;
            GameManager.instance.salt.choice = true;
            subChoice1.SetActive(false);
		}
	}
	public void OnClickSub1_chives()
	{
		if (GameManager.instance.chives.choice == false)
		{
			ingredient.Add(GameManager.instance.chives);
			subCount++;
			sub1_image.sprite = chives_image;
            GameManager.instance.chives.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_radish()
	{
		if (GameManager.instance.radish.choice == false)
		{
			ingredient.Add(GameManager.instance.radish);
			subCount++;
			sub1_image.sprite = radish_image;
            GameManager.instance.radish.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_thick()
	{
		if (GameManager.instance.thick.choice == false)
		{
			ingredient.Add(GameManager.instance.thick);
			subCount++;
			sub1_image.sprite = thick_image;
            GameManager.instance.thick.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_greenOnion()
	{
		if (GameManager.instance.greenOnion.choice == false)
		{
			ingredient.Add(GameManager.instance.greenOnion);
			subCount++;
			sub1_image.sprite = greenOnion_image;
            GameManager.instance.greenOnion.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_mint()
	{
		if (GameManager.instance.mint.choice == false)
		{
			ingredient.Add(GameManager.instance.mint);
			subCount++;
			sub1_image.sprite = mint_image;
            GameManager.instance.mint.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_chocolate()
	{
		if (GameManager.instance.chocolate.choice == false)
		{
			ingredient.Add(GameManager.instance.chocolate);
			subCount++;
			sub1_image.sprite = chocolate_image;
            GameManager.instance.chocolate.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_strawberry()
	{
		if (GameManager.instance.strawberry.choice == false)
		{
			ingredient.Add(GameManager.instance.strawberry);
			subCount++;
			sub1_image.sprite =strawberry_image;
            GameManager.instance.strawberry.choice = true;
            subChoice1.SetActive(false);
		}
	}

	public void OnClickSub1_banana()
	{
		if (GameManager.instance.banana.choice == false)
		{
			ingredient.Add(GameManager.instance.banana);
			subCount++;
			sub1_image.sprite = banana_image;
            GameManager.instance.banana.choice = true;
            subChoice1.SetActive(false);
		}
	}


	/// <summary>
	/// OnClcikSub2
	/// </summary>

	public void OnClickSub2_onion()
	{
		if (GameManager.instance.onion.choice == false)
		{
			ingredient.Add(GameManager.instance.onion);
			subCount++;
			sub2_image.sprite = onion_image;
            GameManager.instance.onion.choice = true;
            subChoice2.SetActive(false);
		}
	}
	public void OnClickSub2_garlic()
	{
		if (GameManager.instance.garlic.choice == false)
		{
			ingredient.Add(GameManager.instance.garlic);
			subCount++;
			sub2_image.sprite = garlic_image;
            GameManager.instance.garlic.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_salt()
	{
		if (GameManager.instance.salt.choice == false)
		{
			ingredient.Add(GameManager.instance.salt);
			subCount++;
			sub2_image.sprite = salt_image;
            GameManager.instance.salt.choice = true;
            subChoice2.SetActive(false);
		}
	}
	public void OnClickSub2_chives()
	{
		if (GameManager.instance.chives.choice == false)
		{
			ingredient.Add(GameManager.instance.chives);
			subCount++;
			sub2_image.sprite = chives_image;
            GameManager.instance.chives.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_radish()
	{
		if (GameManager.instance.radish.choice == false)
		{
			ingredient.Add(GameManager.instance.radish);
			subCount++;
			sub2_image.sprite = radish_image;
            GameManager.instance.radish.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_thick()
	{
		if (GameManager.instance.thick.choice == false)
		{
			ingredient.Add(GameManager.instance.thick);
			subCount++;
			sub2_image.sprite = thick_image;
            GameManager.instance.thick.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_greenOnion()
	{
		if (GameManager.instance.greenOnion.choice == false)
		{
			ingredient.Add(GameManager.instance.greenOnion);
			subCount++;
			sub2_image.sprite = greenOnion_image;
            GameManager.instance.greenOnion.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_mint()
	{
		if (GameManager.instance.mint.choice == false)
		{
			ingredient.Add(GameManager.instance.mint);
			subCount++;
			sub2_image.sprite = mint_image;
            GameManager.instance.mint.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_chocolate()
	{
		if (GameManager.instance.chocolate.choice == false)
		{
			ingredient.Add(GameManager.instance.chocolate);
			subCount++;
			sub2_image.sprite = chocolate_image;
            GameManager.instance.chocolate.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_strawberry()
	{
		if (GameManager.instance.strawberry.choice == false)
		{
			ingredient.Add(GameManager.instance.strawberry);
			subCount++;
			sub2_image.sprite = strawberry_image;
            GameManager.instance.strawberry.choice = true;
            subChoice2.SetActive(false);
		}
	}

	public void OnClickSub2_banana()
	{
		if (GameManager.instance.banana.choice == false)
		{
			ingredient.Add(GameManager.instance.banana);
			subCount++;
			sub2_image.sprite = banana_image;
            GameManager.instance.banana.choice = true;
            subChoice2.SetActive(false);
		}
	}


	/// <summary>
	/// OnClcikSub3
	/// </summary>

	public void OnClickSub3_onion()
	{
		if (GameManager.instance.onion.choice == false)
		{
			ingredient.Add(GameManager.instance.onion);
			subCount++;
			sub3_image.sprite = onion_image;
            GameManager.instance.onion.choice = true;
            subChoice3.SetActive(false);
		}
	}
	public void OnClickSub3_garlic()
	{
		if (GameManager.instance.garlic.choice == false)
		{
			ingredient.Add(GameManager.instance.garlic);
			subCount++;
			sub3_image.sprite = garlic_image;
            GameManager.instance.garlic.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_salt()
	{
		if (GameManager.instance.salt.choice == false)
		{
			ingredient.Add(GameManager.instance.salt);
			subCount++;
			sub3_image.sprite = salt_image;
            GameManager.instance.salt.choice = true;
            subChoice3.SetActive(false);
		}
	}
	public void OnClickSub3_chives()
	{
		if (GameManager.instance.chives.choice == false)
		{
			ingredient.Add(GameManager.instance.chives);
			subCount++;
			sub3_image.sprite = chives_image;
            GameManager.instance.chives.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_radish()
	{
		if (GameManager.instance.radish.choice == false)
		{
			ingredient.Add(GameManager.instance.radish);
			subCount++;
			sub3_image.sprite = radish_image;
            GameManager.instance.radish.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_thick()
	{
		if (GameManager.instance.thick.choice == false)
		{
			ingredient.Add(GameManager.instance.thick);
			subCount++;
			sub3_image.sprite = thick_image;
            GameManager.instance.thick.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_greenOnion()
	{
		if (GameManager.instance.greenOnion.choice == false)
		{
			ingredient.Add(GameManager.instance.greenOnion);
			subCount++;
			sub3_image.sprite = greenOnion_image;
            GameManager.instance.greenOnion.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_mint()
	{
		if (GameManager.instance.mint.choice == false)
		{
			ingredient.Add(GameManager.instance.mint);
			subCount++;
			sub3_image.sprite = mint_image;
            GameManager.instance.mint.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_chocolate()
	{
		if (GameManager.instance.chocolate.choice == false)
		{
			ingredient.Add(GameManager.instance.chocolate);
			subCount++;
			sub3_image.sprite = chocolate_image;
            GameManager.instance.chocolate.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_strawberry()
	{
		if (GameManager.instance.strawberry.choice == false)
		{
			ingredient.Add(GameManager.instance.strawberry);
			subCount++;
			sub3_image.sprite = strawberry_image;
            GameManager.instance.strawberry.choice = true;
            subChoice3.SetActive(false);
		}
	}

	public void OnClickSub3_banana()
	{
		if (GameManager.instance.banana.choice == false)
		{
			ingredient.Add(GameManager.instance.banana);
			subCount++;
			sub3_image.sprite = banana_image;
            GameManager.instance.banana.choice = true;
            subChoice3.SetActive(false);
		}
	}

	/// <summary>
	/// OnClcikSub4
	/// </summary>

	public void OnClickSub4_onion()
	{
		if (GameManager.instance.onion.choice == false)
		{
			ingredient.Add(GameManager.instance.onion);
			subCount++;
			sub4_image.sprite = onion_image;
            GameManager.instance.onion.choice = true;
            subChoice4.SetActive(false);
		}
	}
	public void OnClickSub4_garlic()
	{
		if (GameManager.instance.garlic.choice == false)
		{
			ingredient.Add(GameManager.instance.garlic);
			subCount++;
			sub4_image.sprite = garlic_image;
            GameManager.instance.garlic.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_salt()
	{
		if (GameManager.instance.salt.choice == false)
		{
			ingredient.Add(GameManager.instance.salt);
			subCount++;
			sub4_image.sprite = salt_image;
            GameManager.instance.salt.choice = true;
            subChoice4.SetActive(false);
		}
	}
	public void OnClickSub4_chives()
	{
		if (GameManager.instance.chives.choice == false)
		{
			ingredient.Add(GameManager.instance.salt);
			subCount++;
			sub4_image.sprite = chives_image;
            GameManager.instance.chives.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_radish()
	{
		if (GameManager.instance.radish.choice == false)
		{
			ingredient.Add(GameManager.instance.radish);
			subCount++;
			sub4_image.sprite = radish_image;
            GameManager.instance.radish.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_thick()
	{
		if (GameManager.instance.thick.choice == false)
		{
			ingredient.Add(GameManager.instance.thick);
			subCount++;
			sub4_image.sprite = thick_image;
            GameManager.instance.thick.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_greenOnion()
	{
		if (GameManager.instance.greenOnion.choice == false)
		{
			ingredient.Add(GameManager.instance.greenOnion);
			subCount++;
			sub4_image.sprite = greenOnion_image;
            GameManager.instance.greenOnion.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_mint()
	{
		if (GameManager.instance.mint.choice == false)
		{
			ingredient.Add(GameManager.instance.mint);
			subCount++;
			sub4_image.sprite = mint_image;
            GameManager.instance.mint.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_chocolate()
	{
		if (GameManager.instance.chocolate.choice == false)
		{
			ingredient.Add(GameManager.instance.chocolate);
			subCount++;
			sub4_image.sprite = chocolate_image;
            GameManager.instance.chocolate.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_strawberry()
	{
		if (GameManager.instance.strawberry.choice == false)
		{
			ingredient.Add(GameManager.instance.strawberry);
			subCount++;
			sub4_image.sprite = strawberry_image;
            GameManager.instance.strawberry.choice = true;
            subChoice4.SetActive(false);
		}
	}

	public void OnClickSub4_banana()
	{
		if (GameManager.instance.banana.choice == false)
		{
			ingredient.Add(GameManager.instance.banana);
			subCount++;
			sub4_image.sprite = banana_image;
            GameManager.instance.banana.choice = true;
            subChoice4.SetActive(false);
		}
	}

	/// <summary>
	/// OnClcikSub5
	/// </summary>


	public void OnClickSub5_onion()
	{
		if (GameManager.instance.onion.choice == false)
		{
			ingredient.Add(GameManager.instance.onion);
			subCount++;
			sub5_image.sprite = onion_image;
            GameManager.instance.onion.choice = true;
            subChoice5.SetActive(false);
        }
	}
	public void OnClickSub5_garlic()
	{
		if (GameManager.instance.garlic.choice == false)
		{
			ingredient.Add(GameManager.instance.garlic);
			subCount++;
			sub5_image.sprite = garlic_image;
            GameManager.instance.garlic.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_salt()
	{
		if (GameManager.instance.salt.choice == false)
		{
			ingredient.Add(GameManager.instance.salt);
			subCount++;
			sub5_image.sprite = salt_image;
            GameManager.instance.salt.choice = true;
            subChoice5.SetActive(false);
		}
	}
	public void OnClickSub5_chives()
	{
		if (GameManager.instance.chives.choice == false)
		{
			ingredient.Add(GameManager.instance.chives);
			subCount++;
			sub5_image.sprite = chives_image;
            GameManager.instance.chives.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_radish()
	{
		if (GameManager.instance.radish.choice == false)
		{
			ingredient.Add(GameManager.instance.radish);
			subCount++;
			sub5_image.sprite = radish_image;
            GameManager.instance.radish.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_thick()
	{
		if (GameManager.instance.thick.choice == false)
		{
			ingredient.Add(GameManager.instance.thick);
			subCount++;
			sub5_image.sprite = thick_image;
            GameManager.instance.thick.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_greenOnion()
	{
		if (GameManager.instance.greenOnion.choice == false)
		{
			ingredient.Add(GameManager.instance.greenOnion);
			subCount++;
			sub5_image.sprite = greenOnion_image;
            GameManager.instance.greenOnion.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_mint()
	{
		if (GameManager.instance.mint.choice == false)
		{
			ingredient.Add(GameManager.instance.mint);
			subCount++;
			sub5_image.sprite = mint_image;
            GameManager.instance.mint.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_chocolate()
	{
		if (GameManager.instance.chocolate.choice == false)
		{
			ingredient.Add(GameManager.instance.chocolate);
			subCount++;
			sub5_image.sprite = chocolate_image;
            GameManager.instance.chocolate.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_strawberry()
	{
		if (GameManager.instance.strawberry.choice == false)
		{
			ingredient.Add(GameManager.instance.strawberry);
			subCount++;
			sub5_image.sprite = strawberry_image;
            GameManager.instance.strawberry.choice = true;
            subChoice5.SetActive(false);
		}
	}

	public void OnClickSub5_banana()
	{
		if (GameManager.instance.banana.choice == false)
		{
			ingredient.Add(GameManager.instance.banana);
			subCount++;
			sub5_image.sprite = banana_image;
            GameManager.instance.banana.choice = true;
            subChoice5.SetActive(false);
		}
	}


	void Start()
    {        
        GameManager.instance.chicken.cost=500;        
        GameManager.instance.pork.cost=1500;
		GameManager.instance.beef.cost = 3000;                      
        GameManager.instance.onion.cost=300;        
        GameManager.instance.garlic.cost=300;        
        GameManager.instance.salt.cost = 300;        
        GameManager.instance.chives.cost=300;        
        GameManager.instance.radish.cost = 300;        
        GameManager.instance.thick.cost = 300;        
        GameManager.instance.greenOnion.cost = 300;
		GameManager.instance.mint.cost = 600;        
        GameManager.instance.chocolate.cost = 600;    
        GameManager.instance.strawberry.cost = 600;
        GameManager.instance.banana.cost = 600;
    }
}
