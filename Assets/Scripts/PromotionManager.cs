using TMPro;
using UnityEngine;

public class PromotionManager : MonoBehaviour
{
    [SerializeField] GameObject DontHaveMoney;
    [SerializeField] TextMeshProUGUI maxHpText;
    [SerializeField] TextMeshProUGUI tasteText;
    [SerializeField] TextMeshProUGUI awarenessText;
    [SerializeField] TextMeshProUGUI moneyText;
    public void OnClickPromotion()
    {
        maxHpText.text = "최대체력: "+Player.instance.maxHp.ToString();
        tasteText.text = "맛: " + GameManager.instance.taste.ToString();
        awarenessText.text="인지도: "+GameManager.instance.awareness.ToString();
        moneyText.text = GameManager.instance.moneyText.text;
    }
    public void OnClickPromotionButton()
    {
        if(GameManager.instance.money>=10000)
        {
            GameManager.instance.money -= 10000;
            Player.instance.maxHp += 5;
            maxHpText.text = "최대체력: " + Player.instance.maxHp.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
            DontHaveMoney.SetActive(false);

		}
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void OnClickPromotionButton1()
    {
        if (GameManager.instance.money >= 30000)
        {
            GameManager.instance.money -= 30000;
            Player.instance.maxHp += 20;
            maxHpText.text = "최대체력: " + Player.instance.maxHp.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
			DontHaveMoney.SetActive(false);
		}
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void OnClickPromotionButton2()
    {
        if (GameManager.instance.money >= 100000)
        {
            GameManager.instance.money -= 100000;
            GameManager.instance.taste += 1;
            tasteText.text = "맛: " + GameManager.instance.taste.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
			DontHaveMoney.SetActive(false);
		}
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void OnClickPromotionButton3()
    {
        if (GameManager.instance.money >= 1000000)
        {
            GameManager.instance.money -= 1000000;
            GameManager.instance.taste += 20;
            tasteText.text = "맛: " + GameManager.instance.taste.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
			DontHaveMoney.SetActive(false);
		}
        else
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void OnClickPromotionButton4()
    {
        if (GameManager.instance.money >= 10000 && GameManager.instance.awareness<100)
        {
            GameManager.instance.money -= 10000;
            if (GameManager.instance.awareness + 1 >= 100)
            {
                GameManager.instance.awareness = 100;
            }
            else
            {
                GameManager.instance.awareness += 1;
            }
            awarenessText.text = "인지도: " + GameManager.instance.awareness.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
			DontHaveMoney.SetActive(false);
		}
        else if(GameManager.instance.money < 10000)
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void OnClickPromotionButton5()
    {
        if (GameManager.instance.money >= 200000 && GameManager.instance.awareness < 100)
        {
            GameManager.instance.money -= 200000;
            if (GameManager.instance.awareness + 25 >= 100)
            {
                GameManager.instance.awareness = 100;
            }
            else
            {
                GameManager.instance.awareness += 25;
            }
            awarenessText.text = "인지도: " + GameManager.instance.awareness.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
			DontHaveMoney.SetActive(false);
		}
        else if(GameManager.instance.money < 200000)
        {
            DontHaveMoney.SetActive(true);
        }
    }

    public void OnClickPromotionButton6()
    {
        if (GameManager.instance.money >= 400000 && GameManager.instance.awareness < 100)
        {
            GameManager.instance.money -= 400000;
            if (GameManager.instance.awareness + 50 >= 100)
            {
                GameManager.instance.awareness = 100;
            }
            else
            {
                GameManager.instance.awareness += 50;
            }
            awarenessText.text = "인지도: " + GameManager.instance.awareness.ToString();
            moneyText.text = GameManager.instance.moneyText.text;
			DontHaveMoney.SetActive(false);
		}
        else if(GameManager.instance.money < 400000)
        {
            DontHaveMoney.SetActive(true);
        }
    }
}
