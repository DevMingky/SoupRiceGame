using Newtonsoft.Json;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    //준비시간장면 게임오브젝트
    public GameObject prepare;

    [SerializeField] Sprite chickenSoup;
    [SerializeField] Sprite pigSoup;
    [SerializeField] Sprite cowSoup;
    [SerializeField] Sprite bananaSoup;
    [SerializeField] Sprite chocolateSoup;
    [SerializeField] Sprite mintSoup;
    [SerializeField] Sprite mintChocolateSoup;
    [SerializeField] Sprite strawberrySoup;


    //재료의 구조체
    public struct Ingredient
    {
        public int count;
        public int cost;
        public bool choice;
        public int index;
    }


	//주재료

	//닭고기
	public Ingredient chicken;
    //돼지고기
    public Ingredient pork;
    //소고기
    public Ingredient beef;

    //부재료

    //일반재료
    //양파
    public Ingredient onion;
    //마늘
    public Ingredient garlic;
    //소금
    public Ingredient salt;
    //부추
    public Ingredient chives;
    //무
    public Ingredient radish;
    //우거지
    public Ingredient thick;
    //파
    public Ingredient greenOnion;

    //덕후용부재료
    //민트
    public Ingredient mint;
    //초콜렛
    public Ingredient chocolate;
    //딸기
    public Ingredient strawberry;
    //바나나
    public Ingredient banana;

	
    // 돈
    public TextMeshProUGUI moneyText;
	public TextMeshProUGUI moneyText2;
	[HideInInspector]
	public int money10000;
	[HideInInspector]
	public int money100000000;
	int Money=0;
    public int money
    {
        get { return Money; }
        set 
        {
            Money = value; 

            if(Money>=10000)
               {
               money10000 = Money / 10000;
			   }
            if(money10000>=10000)
            {
				money100000000 = money10000 / 10000;
			}

               if(money>=100000000)
                  {
				moneyText.text = "소지금: "+ money100000000.ToString() + "억"+(money10000%10000).ToString() + "만" + (Money % 10000).ToString() + "원";
                moneyText2.text = moneyText.text;
                if(money10000%10000==0)
                     {
					moneyText.text = "소지금: " + money100000000.ToString() + "억" + (Money % 10000).ToString() + "원";
					moneyText2.text = moneyText.text;
					if (money % 10000 == 0)
					{
                        moneyText.text = "소지금: " + money100000000.ToString() + "억원";
						moneyText2.text = moneyText.text;
					}
				}
			}

                else if(money>=10000)
                   {
				    moneyText.text = "소지금: " + money10000 .ToString()+ "만"+ (Money%10000).ToString()+"원";
				    moneyText2.text = moneyText.text;
				if (money%10000==0)
                           {
					    moneyText.text = "소지금: " + money10000.ToString() + "만원" ;
					    moneyText2.text = moneyText.text;
				}
			    }   
               else
                   {
                   moneyText.text="소지금: "+Money.ToString()+"원";
				    moneyText2.text = moneyText.text;
			    }
      }
 }
 


    //물약
    public struct Potion
    {
        public int count;
        public int healAmount;
        public int cost;
    }
    public Potion smallPotion;
    public Potion middlePotion;
    public Potion bigPotion;







    public class SoupRice
    {
        public string name;
        public string ingredient;
        public int count;
        public Sprite sprite;
        public int cost;
        public int ingredient_count;
        public int spriteIndex;
    }
    public List<SoupRice> menu = new List<SoupRice>();

    //레시피
    [HideInInspector]
    public bool chickenSoupRice_recipe;
	[HideInInspector]
	public bool porkSoupRice_recipe;
	[HideInInspector]
	public bool beefSoupRice_recipe;

	//스탯
	[HideInInspector]
	public int awareness=0;
	[HideInInspector]
	public int taste=0;

    void SetPotion()
    {
        smallPotion.cost = 50000;
        smallPotion.healAmount = 30;
        middlePotion.cost = 150000;
        middlePotion.healAmount = 100;
        bigPotion.cost = 300000;
        bigPotion.healAmount = 200;
    }

    void SetIndex()
    {
        chicken.index = 0;
        pork.index = 1;
        beef.index = 2;
        onion.index = 3;
        garlic.index = 4;
        salt.index = 5;
        chives.index =6 ;
        radish.index = 7;
        thick.index = 8;
        greenOnion.index = 9;
        mint.index = 10;
        chocolate.index = 11;
        strawberry.index = 12;
        banana.index = 13;
    }

    string save_money="save_money";

    string save_awareness="save_awareness";
    string save_taste="save_taste";

    string save_smallPotionCount="save_smallPotionCount";
    string save_middlePotionCount = "save_middlePotionCount";
    string save_bigPotionCount = "save_bigPotionCount";

    string save_day = "save_day";
    string save_hour = "save_hour";
    string save_minute = "save_minute";

    string save_chickenCount = "save_chickenCount";
    string save_porkCount = "save_porkCount";
    string save_beefCount = "save_beefCount";
    string save_onionCount = "save_onionCount";
    string save_garlicCount = "save_garlicCount";
    string save_saltCount = "save_saltCount";
    string save_chivesCount = "save_chivesCount";
    string save_radishCount="save_radishCount";
    string save_thickCount = "save_thickCount";
    string save_greenOnionCount = "save_greenOnionCount";
    string save_mintCount = "save_mintCount";
    string save_chocolateCount = "save_chocolateCount";
    string save_strawberryCount = "save_strawberryCount";
    string save_bananaCount = "save_bananaCount";

    string save_nowHp="save_nowHp";
    string save_maxHp = "save_maxHp";

    string save_refund = "save_refund";

    string save_chickenSoupRice_recipe= "save_chickenSoupRice_recipe";
    string save_porkSoupRice_recipe = "save_porkSoupRice_recipe";
    string save_beefSoupRice_recipe = "save_beefSoupRice_recipe";

    string save_nowWeapon = "save_nowWeapon";

    string save_menuName0="save_menuName0";
    string save_menuName1 = "save_menuName1";
    string save_menuName2 = "save_menuName2";
    string save_menuName3 = "save_menuName3";
    string save_menuName4 = "save_menuName4";
    string save_menuName5 = "save_menuName5";
    string save_menuName6 = "save_menuName6";
    string save_menuName7 = "save_menuName7";
    string save_menuName8 = "save_menuName8";
    string save_menuName9 = "save_menuName9";

    string save_menu0= "save_ingredient0";
    string save_menu1 = "save_ingredient1";
    string save_menu2 = "save_ingredient2";
    string save_menu3 = "save_ingredient3";
    string save_menu4 = "save_ingredient4";
    string save_menu5 = "save_ingredient5";
    string save_menu6 = "save_ingredient6";
    string save_menu7 = "save_ingredient7";
    string save_menu8 = "save_ingredient8";
    string save_menu9 = "save_ingredient9";


    string save_menu0_cost="save_menu0_cost";
    string save_menu1_cost = "save_menu1_cost";
    string save_menu2_cost = "save_menu2_cost";
    string save_menu3_cost = "save_menu3_cost";
    string save_menu4_cost = "save_menu4_cost";
    string save_menu5_cost = "save_menu5_cost";
    string save_menu6_cost = "save_menu6_cost";
    string save_menu7_cost = "save_menu7_cost";
    string save_menu8_cost = "save_menu8_cost";
    string save_menu9_cost = "save_menu9_cost";

    string save_menu0_count="save_menu0_count";
    string save_menu1_count = "save_menu1_count";
    string save_menu2_count = "save_menu2_count";
    string save_menu3_count = "save_menu3_count";
    string save_menu4_count = "save_menu4_count";
    string save_menu5_count = "save_menu5_count";
    string save_menu6_count = "save_menu6_count";
    string save_menu7_count = "save_menu7_count";
    string save_menu8_count = "save_menu8_count";
    string save_menu9_count = "save_menu9_count";

    string save_menu_type_count = "save_menu_type_count";

    string save_menu_spriteIndex0 = "save_menu_spriteIndex0";
    string save_menu_spriteIndex1 = "save_menu_spriteIndex1";
    string save_menu_spriteIndex2 = "save_menu_spriteIndex2";
    string save_menu_spriteIndex3 = "save_menu_spriteIndex3";
    string save_menu_spriteIndex4 = "save_menu_spriteIndex4";
    string save_menu_spriteIndex5 = "save_menu_spriteIndex5";
    string save_menu_spriteIndex6 = "save_menu_spriteIndex6";
    string save_menu_spriteIndex7 = "save_menu_spriteIndex7";
    string save_menu_spriteIndex8 = "save_menu_spriteIndex8";
    string save_menu_spriteIndex9 = "save_menu_spriteIndex9";

    void Save_menu0()
    {
        PlayerPrefs.SetString(save_menuName0, menu[0].name);
        PlayerPrefs.SetString(save_menu0, menu[0].ingredient);
        PlayerPrefs.SetInt(save_menu0_cost, menu[0].cost);
        PlayerPrefs.SetInt(save_menu0_count, menu[0].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex0, menu[0].spriteIndex);
    }

    void Load_menu0()
    {
        SoupRice temp=new SoupRice();
        temp.name=PlayerPrefs.GetString(save_menuName0);
        temp.ingredient=PlayerPrefs.GetString(save_menu0);
        temp.cost=PlayerPrefs.GetInt(save_menu0_cost);
        temp.count=PlayerPrefs.GetInt(save_menu0_count);

        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex0);
        if (temp_spriteIndex==0)
        {
            temp.spriteIndex=0;
            temp.sprite = chickenSoup;
        }
        else if(temp_spriteIndex==1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }




        menu.Add(temp);
    }

    void Save_menu1()
    {
        PlayerPrefs.SetString(save_menuName1, menu[1].name);
        PlayerPrefs.SetString(save_menu1, menu[1].ingredient);
        PlayerPrefs.SetInt(save_menu1_cost, menu[1].cost);
        PlayerPrefs.SetInt(save_menu1_count, menu[1].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex1, menu[1].spriteIndex);
    }

    void Load_menu1()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName1);
        temp.ingredient = PlayerPrefs.GetString(save_menu1);
        temp.cost = PlayerPrefs.GetInt(save_menu1_cost);
        temp.count = PlayerPrefs.GetInt(save_menu1_count);

        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex1);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }
        menu.Add(temp);
    }

    void Save_menu2()
    {
        PlayerPrefs.SetString(save_menuName2, menu[2].name);
        PlayerPrefs.SetString(save_menu2, menu[2].ingredient);
        PlayerPrefs.SetInt(save_menu2_cost, menu[2].cost);
        PlayerPrefs.SetInt(save_menu2_count, menu[2].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex2, menu[2].spriteIndex);
    }

    void Load_menu2()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName2);
        temp.ingredient = PlayerPrefs.GetString(save_menu2);
        temp.cost = PlayerPrefs.GetInt(save_menu2_cost);
        temp.count = PlayerPrefs.GetInt(save_menu2_count);

        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex2);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }
        menu.Add(temp);
    }

    void Save_menu3()
    {
        PlayerPrefs.SetString(save_menuName3, menu[3].name);
        PlayerPrefs.SetString(save_menu3, menu[3].ingredient);
        PlayerPrefs.SetInt(save_menu3_cost, menu[3].cost);
        PlayerPrefs.SetInt(save_menu3_count, menu[3].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex3, menu[3].spriteIndex);
    }

    void Load_menu3()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName3);
        temp.ingredient = PlayerPrefs.GetString(save_menu3);
        temp.cost = PlayerPrefs.GetInt(save_menu3_cost);
        temp.count = PlayerPrefs.GetInt(save_menu3_count);

        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex3);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }

        menu.Add(temp);
    }

    void Save_menu4()
    {
        PlayerPrefs.SetString(save_menuName4, menu[4].name);
        PlayerPrefs.SetString(save_menu4, menu[4].ingredient);
        PlayerPrefs.SetInt(save_menu4_cost, menu[4].cost);
        PlayerPrefs.SetInt(save_menu4_count, menu[4].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex4, menu[4].spriteIndex);
    }

    void Load_menu4()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName4);
        temp.ingredient = PlayerPrefs.GetString(save_menu4);
        temp.cost = PlayerPrefs.GetInt(save_menu4_cost);
        temp.count = PlayerPrefs.GetInt(save_menu4_count);


        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex4);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }

        menu.Add(temp);
    }

    void Save_menu5()
    {
        PlayerPrefs.SetString(save_menuName5, menu[5].name);
        PlayerPrefs.SetString(save_menu5, menu[5].ingredient);
        PlayerPrefs.SetInt(save_menu5_cost, menu[5].cost);
        PlayerPrefs.SetInt(save_menu5_count, menu[5].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex5, menu[5].spriteIndex);
    }

    void Load_menu5()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName5);
        temp.ingredient = PlayerPrefs.GetString(save_menu5);
        temp.cost = PlayerPrefs.GetInt(save_menu5_cost);
        temp.count = PlayerPrefs.GetInt(save_menu5_count);


        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex5);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }

        menu.Add(temp);
    }

    void Save_menu6()
    {
        PlayerPrefs.SetString(save_menuName6, menu[6].name);
        PlayerPrefs.SetString(save_menu6, menu[6].ingredient);
        PlayerPrefs.SetInt(save_menu6_cost, menu[6].cost);
        PlayerPrefs.SetInt(save_menu6_count, menu[6].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex6, menu[6].spriteIndex);
    }

    void Load_menu6()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName6);
        temp.ingredient = PlayerPrefs.GetString(save_menu6);
        temp.cost = PlayerPrefs.GetInt(save_menu6_cost);
        temp.count = PlayerPrefs.GetInt(save_menu6_count);


        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex6);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }

        menu.Add(temp);
    }

    void Save_menu7()
    {
        PlayerPrefs.SetString(save_menuName7, menu[7].name);
        PlayerPrefs.SetString(save_menu7, menu[7].ingredient);
        PlayerPrefs.SetInt(save_menu7_cost, menu[7].cost);
        PlayerPrefs.SetInt(save_menu7_count, menu[7].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex7, menu[7].spriteIndex);
    }

    void Load_menu7()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName7);
        temp.ingredient = PlayerPrefs.GetString(save_menu7);
        temp.cost = PlayerPrefs.GetInt(save_menu7_cost);
        temp.count = PlayerPrefs.GetInt(save_menu7_count);


        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex7);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }

        menu.Add(temp);
    }

    void Save_menu8()
    {
        PlayerPrefs.SetString(save_menuName8, menu[8].name);
        PlayerPrefs.SetString(save_menu8, menu[8].ingredient);
        PlayerPrefs.SetInt(save_menu8_cost, menu[8].cost);
        PlayerPrefs.SetInt(save_menu8_count, menu[8].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex8, menu[8].spriteIndex);
    }

    void Load_menu8()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName8);
        temp.ingredient = PlayerPrefs.GetString(save_menu8);
        temp.cost = PlayerPrefs.GetInt(save_menu8_cost);
        temp.count = PlayerPrefs.GetInt(save_menu8_count);
        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex8);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }
        menu.Add(temp);
    }

    void Save_menu9()
    {
        PlayerPrefs.SetString(save_menuName9, menu[9].name);
        PlayerPrefs.SetString(save_menu9, menu[9].ingredient);
        PlayerPrefs.SetInt(save_menu9_cost, menu[9].cost);
        PlayerPrefs.SetInt(save_menu9_count, menu[9].count);
        PlayerPrefs.SetInt(save_menu_spriteIndex9, menu[9].spriteIndex);
    }

    void Load_menu9()
    {
        SoupRice temp = new SoupRice();
        temp.name = PlayerPrefs.GetString(save_menuName9);
        temp.ingredient = PlayerPrefs.GetString(save_menu9);
        temp.cost = PlayerPrefs.GetInt(save_menu9_cost);
        temp.count = PlayerPrefs.GetInt(save_menu9_count);

        int temp_spriteIndex = PlayerPrefs.GetInt(save_menu_spriteIndex9);
        if (temp_spriteIndex == 0)
        {
            temp.spriteIndex = 0;
            temp.sprite = chickenSoup;
        }
        else if (temp_spriteIndex == 1)
        {
            temp.spriteIndex = 1;
            temp.sprite = pigSoup;
        }
        else if (temp_spriteIndex == 2)
        {
            temp.spriteIndex = 2;
            temp.sprite = cowSoup;
        }
        else if (temp_spriteIndex == 3)
        {
            temp.spriteIndex = 3;
            temp.sprite = mintChocolateSoup;
        }
        else if (temp_spriteIndex == 4)
        {
            temp.spriteIndex = 4;
            temp.sprite = mintSoup;
        }
        else if (temp_spriteIndex == 5)
        {
            temp.spriteIndex = 5;
            temp.sprite = chocolateSoup;
        }
        else if (temp_spriteIndex == 6)
        {
            temp.spriteIndex = 6;
            temp.sprite = bananaSoup;
        }
        else if (temp_spriteIndex == 7)
        {
            temp.spriteIndex = 7;
            temp.sprite = strawberrySoup;
        }
        menu.Add(temp);
    }





    public void OnClickReset()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("리셋완료");
    }

    public void SaveDate()
    {
        PlayerPrefs.SetInt(save_money, money);
        PlayerPrefs.SetInt(save_awareness, awareness);
        PlayerPrefs.SetInt(save_taste, taste);

        PlayerPrefs.SetInt(save_smallPotionCount, smallPotion.count);
        PlayerPrefs.SetInt(save_middlePotionCount, middlePotion.count);
        PlayerPrefs.SetInt(save_bigPotionCount, bigPotion.count);

        PlayerPrefs.SetInt(save_chickenCount, chicken.count);
        PlayerPrefs.SetInt(save_porkCount, pork.count);
        PlayerPrefs.SetInt(save_beefCount, beef.count);
        PlayerPrefs.SetInt(save_onionCount, onion.count);
        PlayerPrefs.SetInt(save_garlicCount, garlic.count);
        PlayerPrefs.SetInt(save_saltCount, salt.count);
        PlayerPrefs.SetInt(save_chivesCount, chives.count);
        PlayerPrefs.SetInt(save_radishCount, radish.count);
        PlayerPrefs.SetInt(save_thickCount, thick.count);
        PlayerPrefs.SetInt(save_greenOnionCount, greenOnion.count);
        PlayerPrefs.SetInt(save_mintCount, mint.count);
        PlayerPrefs.SetInt(save_chocolateCount, chocolate.count);
        PlayerPrefs.SetInt(save_strawberryCount, strawberry.count);
        PlayerPrefs.SetInt(save_bananaCount, banana.count);

        PlayerPrefs.SetInt(save_day, TimeManager.instance.day);
        PlayerPrefs.SetInt(save_hour, TimeManager.instance.hour);
        PlayerPrefs.SetInt(save_minute, TimeManager.instance.minute);

        PlayerPrefs.SetInt(save_maxHp, Player.instance.maxHp);
        PlayerPrefs.SetInt(save_nowHp, Player.instance.nowHp);
        PlayerPrefs.SetInt(save_refund, RefundManager.instance.refund);

        PlayerPrefs.SetInt(save_nowWeapon, Player.instance.nowWeapon.index);
        PlayerPrefs.SetInt(save_menu_type_count, menu.Count);

        if(menu.Count > 0)
        {
            Save_menu0();
        }
        if(menu.Count >1)
        {
            Save_menu1();
        }
        if (menu.Count > 2)
        {
            Save_menu2();
        }
        if (menu.Count > 3)
        {
            Save_menu3();
        }
        if (menu.Count > 4)
        {
            Save_menu4();
        }
        if (menu.Count > 5)
        {
            Save_menu5();
        }
        if (menu.Count > 6)
        {
            Save_menu6();
        }
        if (menu.Count > 7)
        {
            Save_menu7();
        }
        if (menu.Count > 8)
        {
            Save_menu8();
        }
        if (menu.Count > 9)
        {
            Save_menu9();
        }

        Debug.Log("저장완료");
    }

    private void OnApplicationQuit()
    {
    }
    

    private void Awake()
    {
        instance = this;
        SetIndex();
        SetPotion();


        money=PlayerPrefs.GetInt(save_money, 0);
        awareness=PlayerPrefs.GetInt(save_awareness, 10);
        taste=PlayerPrefs.GetInt(save_taste, 0);

        smallPotion.count=PlayerPrefs.GetInt(save_smallPotionCount, 0);
        middlePotion.count=PlayerPrefs.GetInt(save_middlePotionCount, 0);
        bigPotion.count=PlayerPrefs.GetInt(save_bigPotionCount, 0);

        chicken.count=PlayerPrefs.GetInt(save_chickenCount, 0);
        pork.count = PlayerPrefs.GetInt(save_porkCount, 0);
        beef.count = PlayerPrefs.GetInt(save_beefCount, 0);
        onion.count = PlayerPrefs.GetInt(save_onionCount, 0);
        garlic.count = PlayerPrefs.GetInt(save_garlicCount, 0);
        salt.count = PlayerPrefs.GetInt(save_saltCount, 0);
        chives.count = PlayerPrefs.GetInt(save_chivesCount, 0);
        radish.count = PlayerPrefs.GetInt(save_radishCount, 0);
        thick.count = PlayerPrefs.GetInt(save_thickCount, 0);
        greenOnion.count = PlayerPrefs.GetInt(save_greenOnionCount, 0);
        mint.count = PlayerPrefs.GetInt(save_mintCount, 0);
        chocolate.count = PlayerPrefs.GetInt(save_chocolateCount, 0);
        strawberry.count = PlayerPrefs.GetInt(save_strawberryCount, 0);
        banana.count = PlayerPrefs.GetInt(save_bananaCount, 0);

        if(PlayerPrefs.GetInt(save_chickenSoupRice_recipe, 0)==0)
        {
            chickenSoupRice_recipe = false;
        }
        else
        {
            chickenSoupRice_recipe = true;
        }

        if (PlayerPrefs.GetInt(save_porkSoupRice_recipe, 0) == 0)
        {
            porkSoupRice_recipe = false;
        }
        else
        {
            porkSoupRice_recipe = true;
        }

        if (PlayerPrefs.GetInt(save_beefSoupRice_recipe ,0) == 0)
        {
            beefSoupRice_recipe = false;
        }
        else
        {
            beefSoupRice_recipe = true;
        }
        money = money;
    }

    private void Start()
    {
        TimeManager.instance.day = PlayerPrefs.GetInt(save_day, 0);
        TimeManager.instance.hour = PlayerPrefs.GetInt(save_hour, 7);
        TimeManager.instance.minute = PlayerPrefs.GetInt(save_minute, 0);
        Player.instance.nowHp = PlayerPrefs.GetInt(save_nowHp, 100);
        Player.instance.maxHp = PlayerPrefs.GetInt(save_maxHp, 100);
        RefundManager.instance.refund = PlayerPrefs.GetInt(save_refund, 100000000);
        int temp_weaponIndex = PlayerPrefs.GetInt(save_nowWeapon, 0);
        Player.instance.nowWeapon = WeaponManager.instance.weapon[temp_weaponIndex];
        int tempMenuCount = PlayerPrefs.GetInt(save_menu_type_count);

        if (tempMenuCount > 0)
        {
            Load_menu0();
        }
        if (tempMenuCount > 1)
        {
            Load_menu1();
        }
        if (tempMenuCount > 2)
        {
            Load_menu2();
        }
        if (tempMenuCount > 3)
        {
            Load_menu3();
        }
        if (tempMenuCount > 4)
        {
            Load_menu4();
        }
        if (tempMenuCount > 5)
        {
            Load_menu5();
        }
        if (tempMenuCount > 6)
        {
            Load_menu6();
        }
        if (tempMenuCount > 7)
        {
            Load_menu7();
        }
        if (tempMenuCount > 8)
        {
            Load_menu8();
        }
        if (tempMenuCount > 9)
        {
            Load_menu9();
        }
    }







}
