using TMPro;
using UnityEngine;

public class RefundManager : MonoBehaviour
{
	public static RefundManager instance;
	[SerializeField] TextMeshProUGUI myMoney;
	[SerializeField] TextMeshProUGUI refundText;
	[SerializeField] GameObject HappyEnding;
	int refund10000;
	int refund100000000;
	int Refund = 0;
	public int refund
	{
		get 
		{	return Refund; }
		set
		{
			Refund = value;
			if (Refund >= 10000)
			{
				refund10000 = Refund / 10000;
			}
			if (refund10000 >= 10000)
			{
				refund100000000 = refund10000 / 10000;
			}

			if (refund >= 100000000)
			{
				refundText.text = "남은금액: " + refund100000000.ToString() + "억" + (refund10000 % 10000).ToString() + "만" + (Refund % 10000).ToString() + "원";
				if (refund10000 % 10000 == 0)
				{
					refundText.text = "남은금액: " + refund100000000.ToString() + "억" + (Refund % 10000).ToString() + "원";
					if (refund % 10000 == 0)
					{
						refundText.text = "남은금액: " + refund100000000.ToString() + "억원";
					}
				}
			}

			else if (refund >= 10000)
			{
				refundText.text = "남은금액: " + refund10000.ToString() + "만" + (Refund % 10000).ToString() + "원";
				if (refund % 10000 == 0)
				{
					refundText.text = "남은금액: " + refund10000.ToString() + "만원";
				}
			}
			else
			{
				refundText.text = "남은금액: " + refund.ToString() + "원";
			}
		}
	}
	public void OnClickRefund()
	{
		myMoney.text = GameManager.instance.moneyText.text;
	}

	[SerializeField] GameObject DontHaveMoney;
	public void OnClick100()
	{
		if (GameManager.instance.money>=1000000)
		{
			GameManager.instance.money -= 1000000;
			refund -= 1000000;
			myMoney.text = GameManager.instance.moneyText.text;
			refund = refund;
		}
		else
		{
			DontHaveMoney.SetActive(true);
		}
		
		if (Refund <= 0)
		{
			HappyEnding.SetActive(true);
		}
	}

	public void OnClick1000()
	{
		if (GameManager.instance.money >= 10000000)
		{
			GameManager.instance.money -= 10000000;
			refund -= 10000000;
			myMoney.text = GameManager.instance.moneyText.text;
			refund = refund;
		}
		else
		{
			DontHaveMoney.SetActive(true);
		}
		if (Refund <= 0)
		{
			HappyEnding.SetActive(true);
		}
	}

	public void OnClick10000()
	{
		if (GameManager.instance.money >= 100000000)
		{
			GameManager.instance.money -= 100000000;
			refund -= 100000000;
			myMoney.text = GameManager.instance.moneyText.text;
			refund = refund;
		}
		else
		{
			DontHaveMoney.SetActive(true);
		}
		if (Refund <= 0)
		{
			HappyEnding.SetActive(true);
		}
	}

	private void Awake()
	{
		instance = this;
	}
}
