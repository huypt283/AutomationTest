# AutomationTest

#SQL Script
#######################################
For security, they will need to reach the Service Desk directly at ITServiceDesk@AllianceBernstein.com or 
Phone: +1-888-345-2145 for verification, and cannot be requested by other users. Thank you.
CREATE TABLE [dbo].[BankRobbery_Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[team] [int] NULL,
	[age] [int] NULL,
	[role] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[BankRobbery_Person]  WITH CHECK ADD FOREIGN KEY([role])
REFERENCES [dbo].[BankRobbery_Role] ([id])
GO

ALTER TABLE [dbo].[BankRobbery_Person]  WITH CHECK ADD FOREIGN KEY([team])
REFERENCES [dbo].[BankRobbery_Team] ([id])
GO

#######################################

CREATE TABLE [dbo].[BankRobbery_Plan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[location] [int] NULL,
	[team] [int] NULL,
	[expected_revenue] [money] NULL,
	[time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[BankRobbery_Plan]  WITH CHECK ADD FOREIGN KEY([location])
REFERENCES [dbo].[BankRobbery_RobLocation] ([id])
GO

ALTER TABLE [dbo].[BankRobbery_Plan]  WITH CHECK ADD FOREIGN KEY([team])
REFERENCES [dbo].[BankRobbery_Team] ([id])
GO

#######################################

CREATE TABLE [dbo].[BankRobbery_RobLocation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[country] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

#######################################

CREATE TABLE [dbo].[BankRobbery_Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

#######################################

CREATE TABLE [dbo].[BankRobbery_Team](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[team_name] [nvarchar](50) NULL,
	[date_created] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

#######################################
