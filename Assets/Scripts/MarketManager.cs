using TMPro;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] GameObject alreadyBuy;
    [SerializeField] GameObject DontHaveMoney;

    [SerializeField] TextMeshProUGUI []SellMainIngredient = new TextMeshProUGUI[3];

    public void ChoiceSellMain()
    {
        SellMainIngredient[0].text = "닭고기(소유:" + GameManager.instance.chicken.count + ")";
        SellMainIngredient[1].text = "돼지고기(소유:" + GameManager.instance.pork.count + ")";
        SellMainIngredient[2].text = "소고기(소유:" + GameManager.instance.beef.count + ")";
    }
    public void SellMain()
    {
        if(GameManager.instance.chicken.count>0)
        {
            GameManager.instance.chicken.count--;
            GameManager.instance.money=GameManager.instance.chicken.cost;
            moneyText.text = GameManager.instance.moneyText.text;
            SellMainIngredient[0].text = "닭고기(소유:" + GameManager.instance.chicken.count + ")";
        }
    }

    public void SellMain1()
    {
        if (GameManager.instance.pork.count > 0)
        {
            GameManager.instance.pork.count--;
            GameManager.instance.money = GameManager.instance.pork.cost;
            moneyText.text = GameManager.instance.moneyText.text;
            SellMainIngredient[1].text = "돼지고기(소유:" + GameManager.instance.pork.count + ")";
        }
    }

    public void SellMain2()
    {
        if (GameManager.instance.beef.count > 0)
        {
            GameManager.instance.beef.count--;
            GameManager.instance.money = GameManager.instance.beef.cost;
            moneyText.text = GameManager.instance.moneyText.text;
            SellMainIngredient[2].text = "소고기(소유:" + GameManager.instance.beef.count + ")";
        }
    }






    [SerializeField] TextMeshProUGUI[] ingredientText=new TextMeshProUGUI[11];
    public void BuyIngredient()
    {
        if(GameManager.instance.onion.cost<=GameManager.instance.money)
        {
            GameManager.instance.money-=GameManager.instance.onion.cost;
            GameManager.instance.onion.count++;
            ingredientText[0].text = "양파(소유:" + GameManager.instance.onion.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient1()
    {
        if (GameManager.instance.garlic.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.garlic.cost;
            GameManager.instance.garlic.count++;
            ingredientText[1].text = "마늘(소유:" + GameManager.instance.garlic.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient2()
    {
        if (GameManager.instance.salt.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.salt.cost;
            GameManager.instance.salt.count++;
            ingredientText[2].text = "소금(소유:" + GameManager.instance.salt.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient3()
    {
        if (GameManager.instance.chives.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.chives.cost;
            GameManager.instance.chives.count++;
            ingredientText[3].text = "부추(소유:" + GameManager.instance.chives.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient4()
    {
        if (GameManager.instance.radish.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.radish.cost;
            GameManager.instance.radish.count++;
            ingredientText[4].text = "무(소유:" + GameManager.instance.radish.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient5()
    {
        if (GameManager.instance.thick.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.thick.cost;
            GameManager.instance.thick.count++;
            ingredientText[5].text = "우거지(소유:" + GameManager.instance.thick.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient6()
    {
        if (GameManager.instance.greenOnion.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.greenOnion.cost;
            GameManager.instance.greenOnion.count++;
            ingredientText[6].text = "파(소유:" + GameManager.instance.greenOnion.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient7()
    {
        if (GameManager.instance.mint.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.mint.cost;
            GameManager.instance.mint.count++;
            ingredientText[7].text = "민트(소유:" + GameManager.instance.mint.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient8()
    {
        if (GameManager.instance.chocolate.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.chocolate.cost;
            GameManager.instance.chocolate.count++;
            ingredientText[8].text = "초콜릿(소유:" + GameManager.instance.chocolate.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient9()
    {
        if (GameManager.instance.strawberry.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.strawberry.cost;
            GameManager.instance.strawberry.count++;
            ingredientText[9].text = "딸기(소유:" + GameManager.instance.strawberry.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyIngredient10()
    {
        if (GameManager.instance.banana.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.banana.cost;
            GameManager.instance.banana.count++;
            ingredientText[10].text = "바나나(소유:" + GameManager.instance.banana.count.ToString() + ")";
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void choiceBuySub()
    {
        ingredientText[0].text = "양파(소유:" + GameManager.instance.onion.count.ToString() + ")";
        ingredientText[1].text = "마늘(소유:" + GameManager.instance.garlic.count.ToString() + ")";
        ingredientText[2].text = "소금(소유:" + GameManager.instance.salt.count.ToString() + ")";
        ingredientText[3].text = "부추(소유:" + GameManager.instance.chives.count.ToString() + ")";
        ingredientText[4].text = "무(소유:" + GameManager.instance.radish.count.ToString() + ")";
        ingredientText[5].text = "우거지(소유:" + GameManager.instance.thick.count.ToString() + ")";
        ingredientText[6].text = "파(소유:" + GameManager.instance.greenOnion.count.ToString() + ")";
        ingredientText[7].text = "민트(소유:" + GameManager.instance.mint.count.ToString() + ")";
        ingredientText[8].text = "초콜릿(소유:" + GameManager.instance.chocolate.count.ToString() + ")";
        ingredientText[9].text = "딸기(소유:" + GameManager.instance.strawberry.count.ToString() + ")";
        ingredientText[10].text = "바나나(소유:" + GameManager.instance.banana.count.ToString() + ")";
    }

    public void choiceSellSub()
    {
        sellSub[0].text = "양파(소유:" + GameManager.instance.onion.count.ToString() + ")";
        sellSub[1].text = "마늘(소유:" + GameManager.instance.garlic.count.ToString() + ")";
        sellSub[2].text = "소금(소유:" + GameManager.instance.salt.count.ToString() + ")";
        sellSub[3].text = "부추(소유:" + GameManager.instance.chives.count.ToString() + ")";
        sellSub[4].text = "무(소유:" + GameManager.instance.radish.count.ToString() + ")";
        sellSub[5].text = "우거지(소유:" + GameManager.instance.thick.count.ToString() + ")";
        sellSub[6].text = "파(소유:" + GameManager.instance.greenOnion.count.ToString() + ")";
        sellSub[7].text = "민트(소유:" + GameManager.instance.mint.count.ToString() + ")";
        sellSub[8].text = "초콜릿(소유:" + GameManager.instance.chocolate.count.ToString() + ")";
        sellSub[9].text = "딸기(소유:" + GameManager.instance.strawberry.count.ToString() + ")";
        sellSub[10].text = "바나나(소유:" + GameManager.instance.banana.count.ToString() + ")";
    }

    [SerializeField] TextMeshProUGUI []sellSub=new TextMeshProUGUI[11];
    public void SellIngredient()
    {
        if(GameManager.instance.onion.count>0)
        {
            GameManager.instance.onion.count--;
            GameManager.instance.money+=GameManager.instance.onion.cost/2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[0].text= "양파(소유:" + GameManager.instance.onion.count.ToString() + ")";
        }
    }

    public void SellIngredient1()
    {
        if (GameManager.instance.garlic.count > 0)
        {
            GameManager.instance.garlic.count--;
            GameManager.instance.money += GameManager.instance.garlic.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[1].text = "마늘(소유:" + GameManager.instance.garlic.count.ToString() + ")";
        }
    }

    public void SellIngredient2()
    {
        if (GameManager.instance.salt.count > 0)
        {
            GameManager.instance.salt.count--;
            GameManager.instance.money += GameManager.instance.salt.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[2].text = "소금(소유:" + GameManager.instance.salt.count.ToString() + ")";
        }
    }

    public void SellIngredient3()
    {
        if (GameManager.instance.chives.count > 0)
        {
            GameManager.instance.chives.count--;
            GameManager.instance.money += GameManager.instance.chives.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[3].text = "부추(소유:" + GameManager.instance.chives.count.ToString() + ")";
        }
    }

    public void SellIngredient4()
    {
        if (GameManager.instance.radish.count > 0)
        {
            GameManager.instance.radish.count--;
            GameManager.instance.money += GameManager.instance.radish.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[4].text = "무(소유:" + GameManager.instance.radish.count.ToString() + ")";
        }
    }

    public void SellIngredient5()
    {
        if (GameManager.instance.thick.count > 0)
        {
            GameManager.instance.thick.count--;
            GameManager.instance.money += GameManager.instance.thick.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[5].text = "우거지(소유:" + GameManager.instance.thick.count.ToString() + ")";
        }
    }

    public void SellIngredient6()
    {
        if (GameManager.instance.greenOnion.count > 0)
        {
            GameManager.instance.greenOnion.count--;
            GameManager.instance.money += GameManager.instance.greenOnion.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[6].text = "파(소유:" + GameManager.instance.greenOnion.count.ToString() + ")";
        }
    }

    public void SellIngredient7()
    {
        if (GameManager.instance.mint.count > 0)
        {
            GameManager.instance.mint.count--;
            GameManager.instance.money += GameManager.instance.mint.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[7].text = "민트(소유:" + GameManager.instance.mint.count.ToString() + ")";
        }
    }

    public void SellIngredient8()
    {
        if (GameManager.instance.chocolate.count > 0)
        {
            GameManager.instance.chocolate.count--;
            GameManager.instance.money += GameManager.instance.chocolate.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[8].text = "초콜릿(소유:" + GameManager.instance.chocolate.count.ToString() + ")";
        }
    }

    public void SellIngredient9()
    {
        if (GameManager.instance.strawberry.count > 0)
        {
            GameManager.instance.strawberry.count--;
            GameManager.instance.money += GameManager.instance.strawberry.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[9].text = "딸기(소유:" + GameManager.instance.strawberry.count.ToString() + ")";
        }
    }
    public void SellIngredient10()
    {
        if (GameManager.instance.banana.count > 0)
        {
            GameManager.instance.banana.count--;
            GameManager.instance.money += GameManager.instance.banana.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSub[10].text = "바나나(소유:" + GameManager.instance.banana.count.ToString() + ")";
        }
    }






    public void BuyChickenSoupRecipe()
    {
        if(GameManager.instance.chickenSoupRice_recipe==false && GameManager.instance.money>=1000)
        {
            GameManager.instance.chickenSoupRice_recipe = true;
            GameManager.instance.money -= 1000;
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if(GameManager.instance.chickenSoupRice_recipe == true)
            {
                DontHaveMoney.SetActive(false);
                alreadyBuy.SetActive(true);
            }
            else if(GameManager.instance.money < 1000)
            {
                alreadyBuy.SetActive(false);
                DontHaveMoney.SetActive(true);
            }
        }
    }

    public void BuyPorkSoupRecipe()
    {
        if (GameManager.instance.porkSoupRice_recipe == false && GameManager.instance.money >= 50000)
        {
            GameManager.instance.porkSoupRice_recipe = true;
            GameManager.instance.money -= 50000;
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if (GameManager.instance.porkSoupRice_recipe == true)
            {
                DontHaveMoney.SetActive(false);
                alreadyBuy.SetActive(true);
            }
            else if (GameManager.instance.money < 50000)
            {
                alreadyBuy.SetActive(false);
                DontHaveMoney.SetActive(true);
            }
        }
    }

    public void BuyBeefSoupRecipe()
    {
        if (GameManager.instance.beefSoupRice_recipe == false && GameManager.instance.money >= 200000)
        {
            GameManager.instance.beefSoupRice_recipe = true;
            GameManager.instance.money -= 200000;
            moneyText.text = GameManager.instance.moneyText.text;
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if (GameManager.instance.beefSoupRice_recipe == true)
            {
                DontHaveMoney.SetActive(false);
                alreadyBuy.SetActive(true);
            }
            else if (GameManager.instance.money < 200000)
            {
                alreadyBuy.SetActive(false);
                DontHaveMoney.SetActive(true);
            }
        }
    }









    [SerializeField] TextMeshProUGUI smallPotion;
    [SerializeField] TextMeshProUGUI middlePotion;
    [SerializeField] TextMeshProUGUI bigPotion;

    public void ChoicePotion()
    {
        smallPotion.text = "하급 체력회복물약(체력 + 30)(소유: "+GameManager.instance.smallPotion.count.ToString()+")";
        middlePotion.text = "중급 체력회복물약(체력 + 100)(소유: " + GameManager.instance.middlePotion.count.ToString() + ")";
        bigPotion.text = "상급 체력회복물약(체력 + 200)(소유: " + GameManager.instance.bigPotion.count.ToString() + ")";
    }

    public void BuySmallPotion()
    {
        if(GameManager.instance.smallPotion.cost<=GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.smallPotion.cost;
            moneyText.text = GameManager.instance.moneyText.text;
            GameManager.instance.smallPotion.count++;
            smallPotion.text = "하급 체력회복물약(체력 + 30)(소유: " + GameManager.instance.smallPotion.count.ToString() + ")";
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyMiddlePotion()
    {
        if (GameManager.instance.middlePotion.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.middlePotion.cost;
            moneyText.text = GameManager.instance.moneyText.text;
            GameManager.instance.middlePotion.count++;
            middlePotion.text = "중급 체력회복물약(체력 + 100)(소유: " + GameManager.instance.middlePotion.count.ToString() + ")";
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void BuyBigPotion()
    {
        if (GameManager.instance.bigPotion.cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= GameManager.instance.bigPotion.cost;
            moneyText.text = GameManager.instance.moneyText.text;
            GameManager.instance.bigPotion.count++;
            bigPotion.text = "상급 체력회복물약(체력 + 200)(소유: " + GameManager.instance.bigPotion.count.ToString() + ")";
        }
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }
    [SerializeField] TextMeshProUGUI sellSmallPotionText;
    [SerializeField] TextMeshProUGUI sellMiddlePotionText;
    [SerializeField] TextMeshProUGUI sellBigPotionText;


    public void ChoiceSellPotion()
    {
        sellSmallPotionText.text = "하급 체력회복물약(체력 + 30)(소유: " + GameManager.instance.smallPotion.count.ToString() + ")";
        sellMiddlePotionText.text = "중급 체력회복물약(체력 + 100)(소유: " + GameManager.instance.middlePotion.count.ToString() + ")";
        sellBigPotionText.text = "상급 체력회복물약(체력 + 200)(소유: " + GameManager.instance.bigPotion.count.ToString() + ")";
    }

    public void SellSmallPotion()
    {
        if(GameManager.instance.smallPotion.count>0)
        {
            GameManager.instance.smallPotion.count--;
            GameManager.instance.money += GameManager.instance.smallPotion.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellSmallPotionText.text = "하급 체력회복물약(체력 + 30)(소유: " + GameManager.instance.smallPotion.count.ToString() + ")";
        }
    }

    public void SellMiddlePotion()
    {
        if (GameManager.instance.middlePotion.count > 0)
        {
            GameManager.instance.middlePotion.count--;
            GameManager.instance.money += GameManager.instance.middlePotion.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellMiddlePotionText.text = "중급 체력회복물약(체력 + 100)(소유: " + GameManager.instance.middlePotion.count.ToString() + ")";
        }
    }

    public void SellBigPotion()
    {
        if (GameManager.instance.bigPotion.count > 0)
        {
            GameManager.instance.bigPotion.count--;
            GameManager.instance.money += GameManager.instance.bigPotion.cost / 2;
            moneyText.text = GameManager.instance.moneyText.text;
            sellBigPotionText.text = "상급 체력회복물약(체력 + 200)(소유: " + GameManager.instance.bigPotion.count.ToString() + ")";
        }
    }

    /// <summary>
    /// Market을 선택했을때
    /// </summary>
    public void OnClickMarket()
    {
        moneyText.text = GameManager.instance.moneyText.text;
        moneyText.gameObject.SetActive(true);
    }

    public void Exit()
    {
        alreadyBuy.SetActive(false);
        DontHaveMoney.SetActive(false);
    }


    public void BuyWeapon()
    {
        if (WeaponManager.instance.weapon[1].isTrue == false && WeaponManager.instance.weapon[1].cost<=GameManager.instance.money)
        {
            GameManager.instance.money -= WeaponManager.instance.weapon[1].cost;
            moneyText.text=GameManager.instance.moneyText.text;
            WeaponManager.instance.weapon[1].isTrue = true;
            Player.instance.buyWeapon = WeaponManager.instance.weapon[1];
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if(WeaponManager.instance.weapon[1].isTrue == true)
            {
                alreadyBuy.SetActive(true);
                DontHaveMoney.SetActive(false);
            }
            else if(WeaponManager.instance.weapon[1].cost > GameManager.instance.money)
            {
                DontHaveMoney.SetActive(true);
                alreadyBuy.SetActive(false);
            }
        }
    }

    public void BuyWeapon1()
    {
        if (WeaponManager.instance.weapon[2].isTrue == false && WeaponManager.instance.weapon[2].cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= WeaponManager.instance.weapon[2].cost;
            moneyText.text = GameManager.instance.moneyText.text;
            WeaponManager.instance.weapon[2].isTrue = true;
            Player.instance.buyWeapon = WeaponManager.instance.weapon[2];
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if (WeaponManager.instance.weapon[2].isTrue == true)
            {
                alreadyBuy.SetActive(true);
                DontHaveMoney.SetActive(false);
            }
            else if (WeaponManager.instance.weapon[2].cost > GameManager.instance.money)
            {
                DontHaveMoney.SetActive(true);
                alreadyBuy.SetActive(false);
            }
        }
    }

    public void BuyWeapon2()
    {
        if (WeaponManager.instance.weapon[3].isTrue == false && WeaponManager.instance.weapon[3].cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= WeaponManager.instance.weapon[3].cost;
            moneyText.text = GameManager.instance.moneyText.text;
            WeaponManager.instance.weapon[3].isTrue = true;
            Player.instance.buyWeapon = WeaponManager.instance.weapon[3];
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if (WeaponManager.instance.weapon[3].isTrue == true)
            {
                alreadyBuy.SetActive(true);
                DontHaveMoney.SetActive(false);
            }
            else if (WeaponManager.instance.weapon[3].cost > GameManager.instance.money)
            {
                DontHaveMoney.SetActive(true);
                alreadyBuy.SetActive(false);
            }
        }
    }

    public void BuyWeapon3()
    {
        if (WeaponManager.instance.weapon[4].isTrue == false && WeaponManager.instance.weapon[4].cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= WeaponManager.instance.weapon[4].cost;
            moneyText.text = GameManager.instance.moneyText.text;
            WeaponManager.instance.weapon[4].isTrue = true;
            Player.instance.buyWeapon = WeaponManager.instance.weapon[4];
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if (WeaponManager.instance.weapon[4].isTrue == true)
            {
                alreadyBuy.SetActive(true);
                DontHaveMoney.SetActive(false);
            }
            else if (WeaponManager.instance.weapon[4].cost > GameManager.instance.money)
            {
                DontHaveMoney.SetActive(true);
                alreadyBuy.SetActive(false);
            }
        }
    }

    public void BuyWeapon4()
    {
        if (WeaponManager.instance.weapon[5].isTrue == false && WeaponManager.instance.weapon[5].cost <= GameManager.instance.money)
        {
            GameManager.instance.money -= WeaponManager.instance.weapon[5].cost;
            moneyText.text = GameManager.instance.moneyText.text;
            WeaponManager.instance.weapon[5].isTrue = true;
            Player.instance.buyWeapon = WeaponManager.instance.weapon[5];
            alreadyBuy.SetActive(false);
            DontHaveMoney.SetActive(false);
        }
        else
        {
            if (WeaponManager.instance.weapon[5].isTrue == true)
            {
                alreadyBuy.SetActive(true);
                DontHaveMoney.SetActive(false);
            }
            else if (WeaponManager.instance.weapon[5].cost > GameManager.instance.money)
            {
                DontHaveMoney.SetActive(true);
                alreadyBuy.SetActive(false);
            }
        }
    }


}
