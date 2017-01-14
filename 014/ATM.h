#pragma once
#include <string>
#include <iostream>
using namespace std;
class ATM
{

public:
	ATM();
	~ATM();

	int balance;
	int userInput;
	int userDeposit;
	int userWithdraw;
	int GetBalance();

	void DepositMoney();
	void WithdrawMoney();
	void DisplayAtmWelcome();
};

