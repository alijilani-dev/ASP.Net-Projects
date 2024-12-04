using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class CommissionRateManager {
		public static CommissionRate GetCommissionRate(Guid payInCountry, Guid payOutCountry, string modeOfPayment, decimal payInAmount) {
			CommissionRate cr = null;
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CommissionSlabMaster Where PayInCountryId='"+ payInCountry.ToString() +"' And PayOutCountryId='"+ payOutCountry.ToString() +"' And ModeOfPayment='"+ modeOfPayment +"'");

			if(ds.Tables[0].Rows.Count>0) {
				decimal startRange = 0;
				decimal endRange = 0;

				foreach(DataRow dr in ds.Tables[0].Rows) {
					startRange = decimal.Parse(dr["StartRange"].ToString());
					endRange = decimal.Parse(dr["EndRange"].ToString());

					if(startRange == -1) {
						startRange = payInAmount;
					}

					if(endRange == -1) {
						endRange = payInAmount;
					}

					if(startRange <= payInAmount
						&&
						endRange >= payInAmount) {
						cr = new CommissionRate();
						
						cr.PayInCountryId = payInCountry;
						cr.PayOutCountryId = payOutCountry;
						cr.ModeOfPayment = modeOfPayment;
						cr.StartRange = startRange;
						cr.EndRange = endRange;
						cr.BaseToBaseCommissionAmount = decimal.Parse(dr["BaseToBaseCommissionAmount"].ToString());
						cr.BaseToUSDCommissionAmount = decimal.Parse(dr["BaseToUSDCommissionAmount"].ToString());
						cr.PayInCommissionType = (CommissionType) Enum.Parse(typeof(CommissionType),dr["PayInCommissionType"].ToString(),true);
						cr.PayInCommissionAmount = decimal.Parse(dr["PayInCommissionAmount"].ToString());
						cr.PayOutCommissionType = (CommissionType) Enum.Parse(typeof(CommissionType),dr["PayOutCommissionType"].ToString(),true);
						cr.PayOutCurrencyType = (CommissionCurrencyType) Enum.Parse(typeof(CommissionCurrencyType),dr["PayOutCurrencyType"].ToString());
						cr.PayOutCommissionAmount = decimal.Parse(dr["PayOutCommissionAmount"].ToString());
                        cr.RangeFound=true;
						break;
					}
				}
			}
			return cr;
		}
	}
}