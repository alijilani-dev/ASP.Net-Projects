Select 
currencyCode as [Currency Code],
33 as [Company Code],
Right(replicate('0',6),6-Len(cast(rank as nvarchar(6))))+cast(rank as nvarchar(6)) as [Document Number],
cast(year(payInDateTime) as nvarchar(4)) + 
case when month(payInDateTime) < 10 Then '0' Else '' End +
cast(month(payInDateTime) as nvarchar(2)) + 
case when day(payInDateTime) < 10 Then '0' Else '' End +
cast(day(payInDateTime) as nvarchar(2)) [Document Date],
Right(replicate('0',12),12-Len(replace(LTrim(RTrim(cast(cast(payoutAmount as decimal(12,2)) as nvarchar(12)))),'.',''))) + replace(LTrim(RTrim(cast(cast(payoutAmount as decimal(12,2)) as nvarchar(12)))),'.','') as Amount,
coalesce(cast(benFirstName+' '+benLastName as char(50)),space(50)) as [Beneficiary Name],
coalesce(cast(benAccountNumber as char(30)),space(30)) as [Beneficiary Account Number],
coalesce(cast(benAddress as char(50)),space(50)) as [Beneficiary Address],
coalesce(cast(bankName as char(30)),space(30)) as [Beneficiary bank name ],
coalesce(cast(branName as char(30)),space(30)) as [Beneficiary bank branch],
coalesce(cast(remFirstName +' '+remLastName as char(30)),space(30)) as [Remitter Name],
coalesce(cast(remAddress as char(30)),space(30)) as [Remitter Address],
coalesce(cast(extCode as char(8)),space(8)) as [Bank Code],
Case when FinalEntity='Home' Then '2'
When FinalEntity='Bank' Then '1'
End as [Mode of Delivery],
cast(delAddress1 as char(35)) as [Delivery Address  1],
cast(delAddress2 as char(35)) as [Delivery Address  2],
cast(delAddress3 as char(35)) as [Delivery Address  3],
cast(delAddress4 as char(35)) as [Delivery Address  4],
coalesce(cast(ZipCode as char(6)),space(6)) as [PinCode]
From dbo.fn_getDraftTransactionDetailsForAgentAccount('{AgentAccountId}')
Where status='UnPaid'