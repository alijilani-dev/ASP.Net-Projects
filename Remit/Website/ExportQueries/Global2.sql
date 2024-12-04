Select 
poutcl.Code as [Currency Code],
33 as [Company Code],
Substring(td.TransactionNumber,12,6) as [Document Number],
cast(year(td.PayInDateTime) as nvarchar(4)) + 
case when month(td.PayInDateTime) < 10 Then '0' Else '' End +
cast(month(td.PayInDateTime) as nvarchar(2)) + 
case when day(td.PayInDateTime) < 10 Then '0' Else '' End +
cast(day(td.PayInDateTime) as nvarchar(2)) [Document Date],
Right(replicate('0',12),12-Len(replace(LTrim(RTrim(cast(cast(td.PayOutAmount as decimal(12,2)) as nvarchar(12)))),'.',''))) + replace(LTrim(RTrim(cast(cast(td.PayOutAmount as decimal(12,2)) as nvarchar(12)))),'.','') as Amount,
coalesce(cast(bl.FirstName+' '+bl.LastName as char(50)),space(50)) as [Beneficiary Name],
coalesce(cast(bbl.AccountNumber as char(30)),space(30)) as [Beneficiary Account Number],
coalesce(cast(bl.Address as char(50)),space(50)) as [Beneficiary Address],
coalesce(cast(bbl.Name as char(30)),space(30)) as [Beneficiary bank name ],
coalesce(cast(bbl.BranchName as char(30)),space(30)) as [Beneficiary bank branch],
coalesce(cast(cl.FirstName +' '+cl.LastName as char(30)),space(30)) as [Remitter Name],
coalesce(cast(cl.Address as char(30)),space(30)) as [Remitter Address],
coalesce(cast(bnkl.ExternalCode as char(8)),space(8)) as [Bank Code],
Case when pml.FinalEntity='Home' Then '2'
When pml.FinalEntity='Bank' Then '1'
End as [Mode of Delivery],
space(35) as [Delivery Address  1],
space(35) as [Delivery Address  2],
space(35) as [Delivery Address  3],
space(35) as [Delivery Address  4],
coalesce(cast(bbl.ZipCode as char(6)),space(6)) as [PinCode]
From TransactionDetails td
Join CurrencyList pincl On td.PayInCurrencyId = pincl.Id
Join CurrencyList poutcl on td.PayOutCurrencyId = poutcl.Id
Join CustomerList cl On td.CustomerId = cl.Id
Join CustomerList bl On td.BeneficeryId = bl.Id
Left Outer Join BeneficeryBankList bbl On td.BeneficeryBankId = bbl.Id
Join BankList bnkl On td.AssociatedBankId = bnkl.Id
Join PaymentModeList pml On td.PaymentMode = pml.Value
Where td.Status = 'UnPaid'
And td.AssociatedBankId In (Select Id From BankList Where AccountId = '{AgentAccountId}')
Order by VoucherNumber