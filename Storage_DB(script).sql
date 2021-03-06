USE [Storage_DB]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21/03/2020 5:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
	[Age] [nvarchar](50) NULL,
	[Date_Register] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Work_Area]    Script Date: 21/03/2020 5:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Work_Area](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Site_Name] [nvarchar](150) NULL,
	[Email] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[URL] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Comments] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [First_Name], [Last_Name], [Login], [Password], [Role], [Age], [Date_Register]) VALUES (1, N'John', N'J', N'123456', N'123456', N'admin', N'20', CAST(N'2020-03-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Users] ([Id], [First_Name], [Last_Name], [Login], [Password], [Role], [Age], [Date_Register]) VALUES (2, N'sdgfgfg', N'rewrewrf', N'rwerewr', N'434324', N'user', N'33', CAST(N'2020-03-15T20:07:51.177' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[Work_Area] ON 

INSERT [dbo].[Work_Area] ([Id], [Site_Name], [Email], [Login], [Password], [URL], [Phone], [Comments]) VALUES (1, N'name1', N'qwrererf', N'wqdewqed', N'wdwqdwd', N'wwwqdwq', N'4321434', N'cxzcxzv\cv')
INSERT [dbo].[Work_Area] ([Id], [Site_Name], [Email], [Login], [Password], [URL], [Phone], [Comments]) VALUES (2, N'wwww1', N'wdefef', N'wqeqwrd', N'wqrdewqed', N'wqedwqed', N'12313414', N'safdascA')
SET IDENTITY_INSERT [dbo].[Work_Area] OFF
