using UnityEngine.UI;
using TMPro;
using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;

public class BagManager : MonoBehaviour
{
    [SerializeField] GameObject recipeBack;
    [SerializeField] GameObject chickenSoupRiceRecipe;
    [SerializeField] GameObject pigSoupRiceRecipe;
    [SerializeField] GameObject cowSoupRiceRecipe;
    [SerializeField] GameObject DonthaveRecipe;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI nowWeaponText;



    string CheckName(int index)
    {
        string temp = "";
        if (index == 0)
        {
            temp = "닭고기";
        }
        else if (index == 1)
        {
            temp = "돼지고기";
        }
        else if (index == 2)
        {
            temp = "소고기";
        }
        else if (index == 3)
        {
            temp = "양파";
        }
        else if (index == 4)
        {
            temp = "마늘";
        }
        else if (index == 5)
        {
            temp = "소금";
        }
        else if (index == 6)
        {
            temp = "부추";
        }
        else if (index == 7)
        {
            temp = "무";
        }
        else if (index == 8)
        {
            temp = "우거지";
        }
        else if (index == 9)
        {
            temp = "파";
        }
        else if (index == 10)
        {
            temp = "민트";
        }
        else if (index == 11)
        {
            temp = "초콜릿";
        }
        else if (index == 12)
        {
            temp = "딸기";
        }
        else if (index == 13)
        {
            temp = "바나나";
        }
        return temp;
    }



    [SerializeField] TextMeshProUGUI[] SoupRiceText = new TextMeshProUGUI[10];
    [SerializeField] Image[] SoupRice_Image_MyRecipe = new Image[10];
    [SerializeField] TextMeshProUGUI[] RecipeText1 = new TextMeshProUGUI[6];
    [SerializeField] TextMeshProUGUI[] RecipeText2 = new TextMeshProUGUI[6];
    [SerializeField] GameObject[] RecipeButton = new GameObject[10];

    public void MyRecipe()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[0].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText1[i].gameObject.SetActive(true);
            RecipeText1[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe1()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[1].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText1[i].gameObject.SetActive(true);
            RecipeText1[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe2()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[2].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText1[i].gameObject.SetActive(true);
            RecipeText1[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe3()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[3].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText1[i].gameObject.SetActive(true);
            RecipeText1[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe4()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[4].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText1[i].gameObject.SetActive(true);
            RecipeText1[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe5()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[5].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText2[i].gameObject.SetActive(true);
            RecipeText2[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe6()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[6].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText2[i].gameObject.SetActive(true);
            RecipeText2[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe7()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[7].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText2[i].gameObject.SetActive(true);
            RecipeText2[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe8()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[8].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText2[i].gameObject.SetActive(true);
            RecipeText2[i].text = CheckName(temp[i].index);

        }
    }

    public void MyRecipe9()
    {
        List<GameManager.Ingredient> temp = JsonConvert.DeserializeObject<List<GameManager.Ingredient>>(GameManager.instance.menu[9].ingredient);
        for (int i = 0; i < temp.Count; i++)
        {
            RecipeText2[i].gameObject.SetActive(true);
            RecipeText2[i].text = CheckName(temp[i].index);

        }
    }


    public void OnClickMyRecipe()
    {
        for (int i = 0; i < GameManager.instance.menu.Count; i++)
        {
            SoupRiceText[i].text = GameManager.instance.menu[i].name;
            SoupRiceText[i].gameObject.SetActive(true);
            SoupRice_Image_MyRecipe[i].sprite = GameManager.instance.menu[i].sprite;
            RecipeButton[i].SetActive(true);
        }
    }


    public void OnClickBag()
    {
        moneyText.text = GameManager.instance.moneyText.text;
        nowWeaponText.text = "현재무기: " + Player.instance.nowWeapon.name;

    }
    public void OnClickChickenRecipe()
    {
        if (GameManager.instance.chickenSoupRice_recipe)
        {
            recipeBack.SetActive(true);
            chickenSoupRiceRecipe.SetActive(true);
            pigSoupRiceRecipe.SetActive(false);
            cowSoupRiceRecipe.SetActive(false);
            DonthaveRecipe.SetActive(false);
        }
        else
        {
            DonthaveRecipe.SetActive(true);
        }
    }

    public void OnClickPigRecipe()
    {
        if (GameManager.instance.porkSoupRice_recipe)
        {
            recipeBack.SetActive(true);
            pigSoupRiceRecipe.SetActive(true);
            chickenSoupRiceRecipe.SetActive(false);
            cowSoupRiceRecipe.SetActive(false);
            DonthaveRecipe.SetActive(false);
        }
        else
        {
            DonthaveRecipe.SetActive(true);
        }
    }

    public void OnClickCowRecipe()
    {
        if (GameManager.instance.beefSoupRice_recipe)
        {
            recipeBack.SetActive(true);
            cowSoupRiceRecipe.SetActive(true);
            chickenSoupRiceRecipe.SetActive(false);
            pigSoupRiceRecipe.SetActive(false);
            DonthaveRecipe.SetActive(false);
        }
        else
        {
            DonthaveRecipe.SetActive(true);
        }
    }

    public void OnClickRecipeExit()
    {
        recipeBack.SetActive(false);
        chickenSoupRiceRecipe.SetActive(false);
        pigSoupRiceRecipe.SetActive(false);
        cowSoupRiceRecipe.SetActive(false);
        DonthaveRecipe.SetActive(false);
    }

    /// <summary>
    /// 재료가방
    /// </summary>
    [SerializeField] TextMeshProUGUI[] main = new TextMeshProUGUI[3];
    [SerializeField] TextMeshProUGUI[] ingredientCount = new TextMeshProUGUI[11];
    public void OnClickIngredientBag()
    {
        ingredientCount[0].text = "양파(소유:" + GameManager.instance.onion.count.ToString() + ")";
        ingredientCount[1].text = "마늘(소유:" + GameManager.instance.garlic.count.ToString() + ")";
        ingredientCount[2].text = "소금(소유:" + GameManager.instance.salt.count.ToString() + ")";
        ingredientCount[3].text = "부추(소유:" + GameManager.instance.chives.count.ToString() + ")";
        ingredientCount[4].text = "무(소유:" + GameManager.instance.radish.count.ToString() + ")";
        ingredientCount[5].text = "우거지(소유:" + GameManager.instance.thick.count.ToString() + ")";
        ingredientCount[6].text = "파(소유:" + GameManager.instance.greenOnion.count.ToString() + ")";
        ingredientCount[7].text = "민트(소유:" + GameManager.instance.mint.count.ToString() + ")";
        ingredientCount[8].text = "초콜릿(소유:" + GameManager.instance.chocolate.count.ToString() + ")";
        ingredientCount[9].text = "딸기(소유:" + GameManager.instance.strawberry.count.ToString() + ")";
        ingredientCount[10].text = "바나나(소유:" + GameManager.instance.banana.count.ToString() + ")";
        main[0].text = "닭고기(소유:" + GameManager.instance.chicken.count.ToString() + ")";
        main[1].text = "돼지고기(소유:" + GameManager.instance.pork.count.ToString() + ")";
        main[2].text = "소고기(소유:" + GameManager.instance.beef.count.ToString() + ")";
    }






    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] TextMeshProUGUI smallPotionCount;
    [SerializeField] TextMeshProUGUI middlePotionCount;
    [SerializeField] TextMeshProUGUI bigPotionCount;

    /// <summary>
    /// 물약가방
    /// </summary>
    public void OnClickPotionBag()
    {
        hpText.text = "최대체력: " + Player.instance.maxHp.ToString() + "     " + "현재체력: " + Player.instance.nowHp.ToString();
        smallPotionCount.text = GameManager.instance.smallPotion.count.ToString();
        middlePotionCount.text = GameManager.instance.middlePotion.count.ToString();
        bigPotionCount.text = GameManager.instance.bigPotion.count.ToString();
    }

    public void UseSmallPotion()
    {
        if (GameManager.instance.smallPotion.count > 0 && Player.instance.nowHp < Player.instance.maxHp)
        {
            GameManager.instance.smallPotion.count -= 1;
            if (Player.instance.nowHp + 30 > Player.instance.maxHp)
            {
                Player.instance.nowHp = Player.instance.maxHp;
            }
            else
            {
                Player.instance.nowHp += 30;
            }
            hpText.text = "최대체력: " + Player.instance.maxHp.ToString() + "     " + "현재체력: " + Player.instance.nowHp.ToString();
            smallPotionCount.text = GameManager.instance.smallPotion.count.ToString();
        }
    }

    public void UseMiddlePotion()
    {
        if (GameManager.instance.middlePotion.count > 0 && Player.instance.nowHp < Player.instance.maxHp)
        {
            GameManager.instance.middlePotion.count -= 1;
            if (Player.instance.nowHp + 100 > Player.instance.maxHp)
            {
                Player.instance.nowHp = Player.instance.maxHp;
            }
            else
            {
                Player.instance.nowHp += 100;
            }
            hpText.text = "최대체력: " + Player.instance.maxHp.ToString() + "     " + "현재체력: " + Player.instance.nowHp.ToString();
            middlePotionCount.text = GameManager.instance.middlePotion.count.ToString();
        }
    }

    public void UseBigPotion()
    {
        if (GameManager.instance.bigPotion.count > 0 && Player.instance.nowHp < Player.instance.maxHp)
        {
            GameManager.instance.bigPotion.count -= 1;
            if (Player.instance.nowHp + 200 > Player.instance.maxHp)
            {
                Player.instance.nowHp = Player.instance.maxHp;
            }
            else
            {
                Player.instance.nowHp += 200;
            }
            hpText.text = "최대체력: " + Player.instance.maxHp.ToString() + "     " + "현재체력: " + Player.instance.nowHp.ToString();
            bigPotionCount.text = GameManager.instance.bigPotion.count.ToString();
        }
    }
    /// <summary>
    /// 국밥가방
    /// </summary>
    [SerializeField] TextMeshProUGUI[] SoupRice = new TextMeshProUGUI[10];
    [SerializeField] TextMeshProUGUI[] SoupRice_Count = new TextMeshProUGUI[10];
    [SerializeField] Image[] SoupRice_Image = new Image[10];
    [SerializeField] TextMeshProUGUI[] SoupRice_Cost = new TextMeshProUGUI[10];
    public void OnClickSoupRiceBag()
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
        }
    }
}