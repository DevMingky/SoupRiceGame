using UnityEngine.UI;
using TMPro;
using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;

public class SellManager : MonoBehaviour
{
    public static SellManager instance;
    [SerializeField] GameObject[] consumer = new GameObject[4];
    [SerializeField] GameObject[] consumer1 = new GameObject[4];
    [SerializeField] GameObject[] consumer2 = new GameObject[4];
    [SerializeField] GameObject[] consumer3 = new GameObject[4];
    [SerializeField] GameObject[] consumer4 = new GameObject[4];
    [SerializeField] GameObject[] consumer5 = new GameObject[4];
    [SerializeField] GameObject[] consumer6 = new GameObject[4];
    [SerializeField] GameObject[] consumer7 = new GameObject[4];
    [SerializeField] GameObject[] consumer8 = new GameObject[4];
    [SerializeField] TextMeshProUGUI[] consumerText = new TextMeshProUGUI[4];

    string[] soupRiceText_nomal =
    {
        "´ß°í±â±¹¹ä ÁÖ¼¼¿ä",
        "µÅÁö±¹¹ä ÁÖ¼¼¿ä",
        "¼Ò°í±â±¹¹ä ÁÖ¼¼¿ä",
    };

    string[] soupRiceText_special =
    {
        "¹ÎÆ®ÃÊÄÚ·Î ¹ü¹÷ÀÌµÈ ±¹¹äÁÖ¼¼¿ä ¤¾¤¾",
        "¹ÎÆ®°¡ µë»Òµé¾î°£ ±¹¹äÁÖ¼¼¿ä ¤¾¤¾",
        "ÃÊÄÝ¸´ÀÌ µé¾î°£ ´Þ´ÞÇÑ±¹¹äÁÖ¼¼¿ä",
        "µþ±â°¡ ¸¹ÀÌµé¾î°£ ±¹¹äÁÖ¼¼¿ä",
        "¹Ù³ª³ª¸ÀÀÌ³ª´Â ±¹¹äÁÖ¼¼¿ä"
    };


	[SerializeField] TextMeshProUGUI[] SoupRice = new TextMeshProUGUI[10];
	[SerializeField] TextMeshProUGUI[] SoupRice_Count = new TextMeshProUGUI[10];
	[SerializeField] Image[] SoupRice_Image = new Image[10];
	[SerializeField] TextMeshProUGUI[] SoupRice_Cost = new TextMeshProUGUI[10];
	[SerializeField] GameObject[] choiceButton = new GameObject[10];
	[SerializeField] GameObject DontHaveSoupRice;

    public void OnClickChoiceSoupRice()
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
			choiceButton[i].SetActive(true);
		}
	}

    int consumerIndex;
    public void ConsumerIndexChecker(int index)
     {
        consumerIndex = index;
	}

    float plusMoney;
    float CheckPlusMoney(int index, int menuIndex)
    {
		List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[index].ingredient);
        if(temp.Contains(GameManager.instance.chicken) && menuIndex==0)
        {
			plusMoney = 1.2f;
        }
        else if(temp.Contains(GameManager.instance.pork))
        {
			plusMoney = 1.2f;
		}
		else if (temp.Contains(GameManager.instance.beef))
		{
			plusMoney = 1.2f;
		}
		else if (temp.Contains(GameManager.instance.mint) && temp.Contains(GameManager.instance.chocolate))
		{
			plusMoney = 1.2f;
		}
		else if (temp.Contains(GameManager.instance.mint))
		{
			plusMoney = 1.2f;
		}
		else if (temp.Contains(GameManager.instance.chocolate))
		{
			plusMoney = 1.2f;
		}
		else if (temp.Contains(GameManager.instance.strawberry))
		{
			plusMoney = 1.2f;
		}
		else if (temp.Contains(GameManager.instance.banana))
		{
			plusMoney = 1.2f;
		}
        else
        {
            plusMoney = 1f;
        }
		return plusMoney;
    }


    [SerializeField] Image []choiceImage=new Image[4];
	ChoiceMenu[] choiceMenuIndex=new ChoiceMenu[4];
    struct ChoiceMenu
    {
        public int index;
        public float money;
    }
    int tableChoice;
	public void TableChoiceChecker(int index)
    {
        tableChoice = index;
    }

	public void ChoiceSoupRice()
     {
		if (GameManager.instance.menu[0].count > 0)
		{
			GameManager.instance.menu[0].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[0].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//                                                                                                                                                                          plusMoney
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[0].cost * CheckPlusMoney(0, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice1()
	{
		if (GameManager.instance.menu[1].count > 0)
		{
			GameManager.instance.menu[1].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[1].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[1].cost * CheckPlusMoney(1, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice2()
	{
		if (GameManager.instance.menu[2].count > 0)
		{
			GameManager.instance.menu[2].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[2].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[2].cost * CheckPlusMoney(2, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice3()
	{
		if (GameManager.instance.menu[3].count > 0)
		{
			GameManager.instance.menu[3].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[3].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[3].cost * CheckPlusMoney(3, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice4()
	{
		if (GameManager.instance.menu[4].count > 0)
		{
			GameManager.instance.menu[4].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[4].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[4].cost * CheckPlusMoney(4, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice5()
	{
		if (GameManager.instance.menu[5].count > 0)
		{
			GameManager.instance.menu[5].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[5].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[5].cost * CheckPlusMoney(5, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice6()
	{
		if (GameManager.instance.menu[6].count > 0)
		{
			GameManager.instance.menu[6].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[6].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[6].cost * CheckPlusMoney(6, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice7()
	{
		if (GameManager.instance.menu[7].count > 0)
		{
			GameManager.instance.menu[7].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[7].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[7].cost * CheckPlusMoney(7, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice8()
	{
		if (GameManager.instance.menu[8].count > 0)
		{
			GameManager.instance.menu[8].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[8].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[8].cost * CheckPlusMoney(8, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}

	public void ChoiceSoupRice9()
	{
		if (GameManager.instance.menu[9].count > 0)
		{
			GameManager.instance.menu[9].count--;
			choiceImage[consumerIndex].sprite = GameManager.instance.menu[9].sprite;
			if (consumerIndex == 0)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer.menu.index;
			}
			else if (consumerIndex == 1)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer1.menu.index;
			}
			else if (consumerIndex == 2)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer2.menu.index;
			}
			else if (consumerIndex == 3)
			{
				choiceMenuIndex[consumerIndex].index = table[tableChoice].consumer3.menu.index;
			}
			//
			choiceMenuIndex[consumerIndex].money = GameManager.instance.menu[9].cost * CheckPlusMoney(9, choiceMenuIndex[consumerIndex].index);
			DontHaveSoupRice.SetActive(false);
		}
		else
		{
			DontHaveSoupRice.SetActive(true);
		}
	}
	GameObject []CheckConsumer()
    {
        if (nowTableNum == 0)
        {
            return consumer;
        }
        else if (nowTableNum == 1)
        {
            return consumer1;
        }
        else if (nowTableNum == 2)
        {
            return consumer2;
        }
        else if (nowTableNum == 3)
        {
            return consumer3;
        }
        else if (nowTableNum == 4)
        {
            return consumer4;
        }
        else if (nowTableNum == 5)
        {
            return consumer5;
        }
        else if (nowTableNum == 6)
        {
            return consumer6;
        }
        else if (nowTableNum == 7)
        {
            return consumer7;
        }
        else if (nowTableNum == 8)
        {
            return consumer8;
        }
        return null;
    }



    struct Menu
    {
        public string text;
        public int index;
    }


    /// <summary>
    /// 0.´ß°í±â
    /// 1.µÅÁö
    /// 2.¼Ò°í±â
    /// </summary>
    Menu[] menu_nomal = new Menu[3];
    /// <summary>
    /// 0.¹ÎÆ®ÃÊÄÚ
    /// 1.¹ÎÆ®
    /// 2.ÃÊÄÝ¸´
    /// 3.µþ±â
    /// 4.ºñ³ª³ª
    /// </summary>
    Menu[] menu_special = new Menu[5];


    struct Consumer
    {
        public Menu menu;
    }

    struct Table
    {
        public bool full;
        public int consumerCount;
        public Consumer consumer;
        public Consumer consumer1;
        public Consumer consumer2;
        public Consumer consumer3;
    }

    Table []table=new Table[9];

    [SerializeField] GameObject[] orderButton = new GameObject[9];
    public void ComeConsumer()
    {
        int aware = Random.Range(0, 100);
    if(table[nowTableNum].full == false && aware<GameManager.instance.awareness)
    { 
        table[nowTableNum].full = true;
        int consumerCount=Random.Range(1, 5);
        table[nowTableNum].consumerCount = consumerCount;
            for (int i = 0; i < consumerCount; i++)
            {

                int temp = Random.Range(0, 10);
                //ÀÏ¹Ý¼Õ´Ô
                if (temp < 8)
                {
                    int temp2 = Random.Range(0, 3);
                    table[nowTableNum].consumer.menu.index = i;
					if(table[nowTableNum].consumer.menu.text==null)
                         {
						table[nowTableNum].consumer.menu.text = soupRiceText_nomal[temp2];
					}
                    else if(table[nowTableNum].consumer1.menu.text == null)
                         {
						table[nowTableNum].consumer1.menu.text = soupRiceText_nomal[temp2];
					}
					else if (table[nowTableNum].consumer2.menu.text == null)
					{
						table[nowTableNum].consumer2.menu.text = soupRiceText_nomal[temp2];
					}
					else if (table[nowTableNum].consumer3.menu.text == null)
					{
						table[nowTableNum].consumer3.menu.text = soupRiceText_nomal[temp2];
					}

				}
                //´öÈÄ¼Õ´Ô
                else
                {
                    int temp2 = Random.Range(0, 5);
                    table[nowTableNum].consumer.menu.index = 3 + i;
					if (table[nowTableNum].consumer.menu.text == null)
					{
						table[nowTableNum].consumer.menu.text = soupRiceText_special[temp2];
					}
					else if (table[nowTableNum].consumer1.menu.text == null)
					{
						table[nowTableNum].consumer1.menu.text = soupRiceText_special[temp2];
					}
					else if (table[nowTableNum].consumer2.menu.text == null)
					{
						table[nowTableNum].consumer2.menu.text = soupRiceText_special[temp2];
					}
					else if (table[nowTableNum].consumer3.menu.text == null)
					{
						table[nowTableNum].consumer3.menu.text = soupRiceText_special[temp2];
					}
				}
                orderButton[nowTableNum].SetActive(true);
                CheckConsumer()[i].SetActive(true);
            }
        }

    }


    [SerializeField] GameObject []choiceSoupRice=new GameObject[4];
    public void OnClickOrder(int index)
    {
		OnClickChoiceSoupRice();
        for (int i = 0; i < 4; i++)
        {
			choiceSoupRice[i].SetActive(false);
		}
        for (int i = 0; i < 4; i++)
          {
			consumerText[i].text =null;
		}
		consumerText[0].text = table[index].consumer.menu.text;
		consumerText[1].text = table[index].consumer1.menu.text;
		consumerText[2].text = table[index].consumer2.menu.text;
		consumerText[3].text = table[index].consumer3.menu.text;
        for (int i = 0; i < 4; i++)
        {
			if (consumerText[i].text != null)
			{
				choiceSoupRice[i].SetActive(true);
			}
		}
   
	}




    int nowTableNum;

    void CheckNowTable()
    {
        if (table[0].full == false)
        {
            nowTableNum = 0;
        }
        else if ((table[1].full == false))
        {
            nowTableNum = 1;
        }
        else if ((table[2].full == false))
        {
            nowTableNum = 2;
        }
        else if ((table[3].full == false))
        {
            nowTableNum = 3;
        }
        else if (table[4].full == false)
        {
            nowTableNum = 4;
        }
        else if (table[5].full == false)
        {
            nowTableNum = 5;
        }
        else if (table[6].full == false)
        {
            nowTableNum = 6;
        }
        else if (table[7].full == false)
        {
            nowTableNum = 7;
        }
        else if (table[8].full == false)
        {
            nowTableNum = 8;
        }
    }
	[SerializeField] TextMeshProUGUI moneyEffectText;
	IEnumerator MoneyEffect()
	{
		moneyEffectText.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		moneyEffectText.gameObject.SetActive(false);
	}


	

	public void Give()
	{
		int tempMoney = 0;
		orderButton[tableChoice].SetActive(false);
		table[tableChoice].full = false;
		table[tableChoice].consumer.menu.text = null;
		table[tableChoice].consumer1.menu.text = null;
		table[tableChoice].consumer2.menu.text = null;
		table[tableChoice].consumer3.menu.text = null;
		for (int i = 0; i < 4; i++)
		{
			if (tableChoice == 0)
			{
				consumer[i].SetActive(false);
			}
			else if (tableChoice == 1)
			{
				consumer1[i].SetActive(false);
			}
			else if (tableChoice == 2)
			{
				consumer2[i].SetActive(false);
			}
			else if (tableChoice == 3)
			{
				consumer3[i].SetActive(false);
			}
			else if (tableChoice == 4)
			{
				consumer4[i].SetActive(false);
			}
			else if (tableChoice == 5)
			{
				consumer5[i].SetActive(false);
			}
			else if (tableChoice == 6)
			{
				consumer6[i].SetActive(false);
			}
			else if (tableChoice == 7)
			{
				consumer7[i].SetActive(false);
			}
			else if (tableChoice == 8)
			{
				consumer8[i].SetActive(false);
			}
		}

		for (int i = 0; i < table[tableChoice].consumerCount; i++)
		{
			tempMoney += (int)choiceMenuIndex[i].money;
		}
        for (int i = 0; i < table[tableChoice].consumerCount; i++)
        {
            choiceMenuIndex[i].money=0;
        }

        if (tempMoney >= 10000)
		{
			int tempMoney10000= tempMoney/10000;
			moneyEffectText.text = "+" + tempMoney10000.ToString()+"¸¸"+ tempMoney%10000 + "¿ø";
		}
		else
		{ 
			moneyEffectText.text = "+" + tempMoney.ToString() + "¿ø";
		}
		for (int i = 0; i < 4; i++)
		{
			choiceImage[i].sprite = null;
		}
		tempMoney *= (int)(1 + (0.01 * GameManager.instance.taste));
		GameManager.instance.money += tempMoney;
		StartCoroutine(MoneyEffect());
	}

    private void Update()
    {
        CheckNowTable();
    }



    private void Awake()
    {
        instance=this;
    }




}
