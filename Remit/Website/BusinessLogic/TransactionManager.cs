using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class TransactionManager {
		/*
		public static TransactionValidationResult ValidateGlobalThreshold(decimal payinAmount, decimal exchangeRate) {
			TransactionValidationResult tvr = new TransactionValidationResult(true, "Validation done!");
			
			// Validation 1
			// Check for Global Threshold
			decimal globalThreshold = 7500;
			decimal amountUSD = 0;

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From GlobalSettings");
			
			if(ds.Tables[0].Rows.Count>0) {
				DataRow dr = ds.Tables[0].Rows[0];
				try {
					globalThreshold = decimal.Parse(dr["TransactionThresholdUSD"].ToString());
				}catch{}
			}
			amountUSD = payinAmount * exchangeRate;

			if(amountUSD > globalThreshold) {
				tvr = new TransactionValidationResult(false,"PayIn Amount is greater than Global Threshold of "+globalThreshold+" USD!");
			}
			return tvr;
		}*/

		
		public static TransactionValidationResult ValidateGlobalThreshold(decimal payinAmount, decimal exchangeRate, string finalentity)
		{
			TransactionValidationResult tvr = new TransactionValidationResult(true, "Validation done!");
			
			// Validation 1
			// Check for Global Threshold
			decimal globalThreshold = 7500;
			decimal amountUSD = 0;

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From GlobalSettings");
			
			if(ds.Tables[0].Rows.Count>0) 
			{
				DataRow dr = ds.Tables[0].Rows[0];
				try 
				{
					if(finalentity == ExchangeRateFromEntityList.Bank.ToString())
					{
						globalThreshold = decimal.Parse(dr["BankTransactionThresholdUSD"].ToString());
					}
					else// if (finalentity == "Agent")
					{
						globalThreshold = decimal.Parse(dr["TransactionThresholdUSD"].ToString());
					}
				}
				catch{}
			}
			amountUSD = payinAmount * exchangeRate;

			if(amountUSD > globalThreshold) 
			{
				tvr = new TransactionValidationResult(false,"PayIn Amount is greater than Global Threshold of "+globalThreshold+" USD!");
			}
			return tvr;
		}

		public static TransactionValidationResult ValidateAgainstAgentCreditBalance(decimal payinAmount, decimal exchangeRate, decimal remainingBalance) {
			TransactionValidationResult tvr = new TransactionValidationResult(true, "Validation done!");

			// Validation 2
			// Credit balance of Payin Agent
			decimal amountUSD = payinAmount * exchangeRate;

			if(amountUSD > remainingBalance) {
				tvr = new TransactionValidationResult(false, "Agent Account does not have enought credit left for transaction!");
			}
			return tvr;
		}

		public static TransactionValidationResult ValidateAgainstOutBoundIDRequirement(Guid payinCountryId,
			decimal payinAmount, bool hasValidID) {

			TransactionValidationResult tvr = new TransactionValidationResult(true,"Validation done!");

			Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList aoCountryList
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConfigHelper.ConStr);

			aoCountryList.Refresh(payinCountryId);

			if(aoCountryList.Col_OutboundIDRequirementThreshold.Value <= payinAmount) {
				if(!hasValidID) {
					tvr = new TransactionValidationResult(false, "Valid ID required for sending more than "+decimal.Round(aoCountryList.Col_OutboundIDRequirementThreshold.Value,0).ToString());
				}
			}
			return tvr;
		}

		public static TransactionValidationResult ValidateAgainstNumberOfTransactionsPerYear(Guid customerId, Guid beneficeryId, Guid payoutCountryId) {
			TransactionValidationResult tvr = new TransactionValidationResult(true,"");
			Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList aoCountry 
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConfigHelper.ConStr);

			if(!aoCountry.Col_MaximumTransactionsPerYearPerPersonToOneBeneficery.IsNull) {
				if(aoCountry.Col_MaximumTransactionsPerYearPerPersonToOneBeneficery.Value>-1) {
					DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select Id From TransactionDetails td Join LocationList ll On td.PayOutLocationId=ll.Id Join CountryList cl On ll.CountryId=cl.Id Where CustomerId='"+ customerId.ToString() +"' And BeneficeryId='"+ beneficeryId.ToString() +"' and cl.Id='"+ payoutCountryId.ToString() +"' And PayInDateTime Between '"+ aoCountry.Col_TransactionYearStartDate.ToString() +"' And '"+ aoCountry.Col_TransactionYearEndDate.ToString() +"' ");

					if(ds.Tables[0].Rows.Count>=aoCountry.Col_MaximumTransactionsPerYearPerPersonToOneBeneficery.Value) {
						tvr = new TransactionValidationResult(false,"Number of transactions from same customer to benificery within a year is more than permissible level");
					}
				}
			}
			return tvr;
		}
	}
}