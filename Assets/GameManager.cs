using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int money;

    private int moneyLost;
    
    public float cooldown;
    

    private float counter;

    public Text MoneyText;


    public List<string> Names = new List<string>();

    public List<int> Numbers = new List<int>();

    public List<int> Costs = new List<int>();

    public List<int> Cooldown = new List<int>();

    public List<int> Rates =new List<int>();

    private List<float> Counters = new List<float>() { 0, 0, 0,};

    public Text Aka47ButtonText;

    public Text SniperButtonText;

    public Text NurseButtonText;

    public Text TankButtonText;

    public Text HelicopterButtonText;


    void Start()
    {
        money = 0;
        MoneyText.text = "Money earn : 0";
        /* int result = 0;
        result = 5 + 2;
        Debug.Log(result);

        for(int i = 0; i < 20; i++){
            result = Increment(result);
        }

        result = Add(result, 5);
        result = Add(result, 5);
        result ++;
        result ++;
        Debug.Log(result);
        result = Add(result, 3);
        */
       
    }

     public void ManualIncrement()
    {
        money = Increment(1);
    }

    public void BuyAka47()
    {
        if(money >= Costs[0])
        {
            money -= Costs[0];
            UpdateMoneyDisplay(money);
            Numbers[0]++;
            Aka47ButtonText.text = Names[0] + " : " + Numbers[0].ToString();

        }
    }

    public void BuySniper()
    {
        if(money >= Costs[1])
        {
            money -= Costs[1];
            UpdateMoneyDisplay(money);
            Numbers[1]++;
            SniperButtonText.text = Names[1] + " : " + Numbers[1].ToString();
        }
    }

    public void BuyNurse()
    {
        if(money >= Costs[2])
        {
            money -= Costs[2];
            UpdateMoneyDisplay(money);
            Numbers[2]++;
            NurseButtonText.text = Names[2] + " : " + Numbers[2].ToString();
        }
    }

    public void BuyTank()
    {
        if(money >= Costs[3])
        {
            money -= Costs[3];
            UpdateMoneyDisplay(money);
            Numbers[3]++;
            TankButtonText.text = Names[3] + " : " + Numbers[3].ToString();
        }
    }

    public void BuyHelicopter()
    {
        if(money >= Costs[4])
        {
            money -= Costs[4];
            UpdateMoneyDisplay(money);
            Numbers[4]++;
            HelicopterButtonText.text = Names[4] + " : " + Numbers[4].ToString();
        }
    }


    public int Increment(int value) 
    {

        int total = money + value;
        UpdateMoneyDisplay(total);
        return total;

    }

    /*int Add (int a, int b)
    {
        int resultatlocal = a + b;
        Debug.Log(resultatlocal);
        return resultatlocal;
    }
    */

    void Update()
    {
        counter += Time.deltaTime;
        Counters[0] += Time.deltaTime;
        if (counter >= cooldown){
           money = Increment(1);
           counter -= cooldown;
        }

        if(Counters[0] >= Cooldown[0])
        {
            money = Increment(Rates[0]);
            Counters[0] -= Cooldown[0];
        }

    }

    private void UpdateMoneyDisplay(int newNumber)
    {
        MoneyText.text = "Money earn : " + newNumber.ToString();

    }
}
