
--366				All
--255		-0		'Select...'
--94		-1		'Simfree'
--16		-2		'Ex - Network'
--1		-3		'Refurbished'

--select Count(*) from trade_floor where status = '0' and  status <> '1' and  status <> '0' and  status <> '3'

begin transaction

update trade_floor set status = 'Select...' where status = '0'
update trade_floor set status = 'Simfree' where status = '1'
update trade_floor set status = 'Ex - Network' where status = '2'
update trade_floor set status = 'Refurbished' where status = '3'
commit transaction
rollback transaction