--use AMSDashboard
Delete From [AMSDashboardTest].[dbo].[Alert]
DBCC CHECKIDENT("[AMSDashboardTest].[dbo].[Alert]", RESEED, 0); 

Delete FROM [AMSDashboardTest].[dbo].[Program]
Delete FROM [AMSDashboardTest].[dbo].[Channel]
Delete FROM [AMSDashboardTest].[dbo].[Origin]

Delete From [AMSDashboardTest].[dbo].[MediaServicesAccount]
DBCC CHECKIDENT("[AMSDashboardTest].[dbo].[MediaServicesAccount]", RESEED, 0);