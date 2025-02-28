USE [employeeSampleData]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 19/02/2025 11:07:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[HouseNumber] [nvarchar](10) NULL,
	[StreetAddress] [nvarchar](100) NULL,
	[Barangay] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A10H', N'Jose', N'H.', N'Santos', N'Barangay DSWD Worker', N'890', N'Bayanihan St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-352-3456')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A11I', N'Ana', N'I.', N'Torres', N'Barangay Women’s Representative', N'234', N'Veracruz St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-353-4567')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A12J', N'Raul', N'J.', N'Vargas', N'Barangay Youth Representative', N'123', N'Mabini St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-354-5678')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A13K', N'Rosa', N'K.', N'Cruz', N'Barangay Public Relations Officer', N'345', N'Bucal St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-355-6789')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A3F', N'Don', N'A.', N'Bueno', N'Barangay Treasurer', N'123', N'Segovia St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-345-6789')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A4B', N'Carlos', N'B.', N'Garcia', N'Barangay Captain', N'245', N'Marcos St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-346-7890')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A5C', N'Maria', N'C.', N'Ramos', N'Barangay Kagawad', N'345', N'Rizal St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-347-8901')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A6D', N'Juan', N'D.', N'Martinez', N'Barangay Secretary', N'456', N'Tagumpay St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-348-9012')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A7E', N'Lucia', N'E.', N'Lopez', N'Barangay Treasurer', N'567', N'Quezon St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-349-0123')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A8F', N'Emilio', N'F.', N'Zaragoza', N'Barangay Health Worker', N'678', N'Guerrero St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-350-1234')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [MiddleName], [LastName], [Position], [HouseNumber], [StreetAddress], [Barangay], [City], [Province], [ContactNumber]) VALUES (N'INOS1A9G', N'Anna', N'G.', N'Fernandez', N'Barangay Tanod', N'789', N'San Jose St', N'Inosluban', N'Lipa', N'Batangas', N'+63-912-351-2345')
GO
