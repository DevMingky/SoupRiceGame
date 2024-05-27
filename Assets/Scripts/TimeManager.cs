using System.Collections;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
	public static TimeManager instance;

	[SerializeField] TextMeshProUGUI time;
	[SerializeField] GameObject badEnding;
	[SerializeField] GameObject sellTime;
	[SerializeField] GameObject prepareTime;

	public int Day;
	public int day
	{
		get { return Day; }
		set
		{ 
			Day = value;
			time.text = day.ToString() + "일차     " + hour.ToString() + "시" + minute.ToString() + "분";
			if(Day==90)
			{
				GameManager.instance.awareness -= 10;
			}
		}
	}

	[SerializeField] GameObject getSleep;
	Coroutine coru;
	public int Hour=7;
	public int hour
	{
		get { return Hour; }
		set
		{
            Hour = value;
			time.text = day.ToString() + "일차     " + hour.ToString() + "시" + minute.ToString()+"분";
		}
	}
	public int Minute;
	public int minute
	{
		 get { return Minute; }
		 set
		{
			Minute = value;
			time.text = day.ToString() + "일차     " + hour.ToString() + "시" + minute.ToString() + "분";
			if(minute%5==0)
			{
				SellManager.instance.ComeConsumer();
			}
		}	
	}
	public void PassTime()
	{
		hour+= 1;
	}

	IEnumerator SellTime()
	{
		while(true)
		{
			minute+=1;
			yield return new WaitForSeconds(0.25f);
		}
	}

	IEnumerator GetSleep()
	{
		getSleep.SetActive(true);
		yield return new WaitForSeconds(5f);
		getSleep.SetActive(false);
		Player.instance.nowHp = Player.instance.maxHp;
	}
	private void Awake()
	{
		instance = this;
		hour = 7;
		time.text = day.ToString() + "일차     " + hour.ToString() + "시" + minute.ToString() + "분";
	}


	public bool isSellTime;
	public bool isPrepareTime;
	bool alreadySellTime;
	bool alreadyPrepareTime;
	void BadEnding()
	{
		badEnding.SetActive(true);
	}





	float tempTime;
	private void Update()
	{
		if (hour >= 24)
		{
			day++;
			hour = 0;
		}
		if (minute >= 60)
		{
			hour++;
			minute = 0;
		}
		if (day > 360)
		{
			BadEnding();
			day = 0;
		}

		//잠자는시간
		if(hour>=0 && hour<7)
		{
			hour = 7;
            StartCoroutine(GetSleep());
        }
		else if(hour>=7 && hour<17)
		{
            isPrepareTime = true;
			isSellTime = false;
		}
		else if(hour>=17 && hour<=24)
		{
			isSellTime=true;
			isPrepareTime=false;
		}


		if (isPrepareTime)
		{
			if (alreadyPrepareTime == false)
			{
				prepareTime.SetActive(true);
				sellTime.SetActive(false);
                alreadyPrepareTime=true;
				alreadySellTime = false;
            }
		}
		else if (isSellTime)
		{
			if (alreadySellTime == false)
			{
                prepareTime.SetActive(false);
                sellTime.SetActive(true);
                alreadyPrepareTime = false;
                alreadySellTime = true;
            }

			tempTime += Time.deltaTime;
			if (tempTime>=0.5f)
			{
				minute++;
				tempTime = 0;

            }
		}
	}

	
}
