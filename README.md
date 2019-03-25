# extendingepiserveredit

To get started with this you need to do a couple of things.

1: If you do not have SQL Server installed you need to download and install it. You can get a free developer version here: https://www.microsoft.com/en-us/sql-server/sql-server-editions-developers
2: Create a new database on your local default instance (the . in the connectionstring) called ExtendingEditUi
3: Open the Package Manager Console and run: Initialize-EPiDatabase
4: Open your SQL Management studio and select a new Query against the database ExtendingEditUi and run this SQL-script there:

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserProfile](
	[UserId] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[PhoneNumber] [varchar](50) NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

5: The site are set to run with the SQL Memebership provider and it will automaticly create a sql user with the name EpiSQLAdmin and password 6hEthU
6: Log in with that user and go to Admin where you first set another password for the user, or create your own and then set access rights to the groups WebEditors and WebAdmins
