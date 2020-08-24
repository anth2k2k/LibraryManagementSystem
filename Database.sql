USE [Library]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 8/24/2020 9:13:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[title] [nvarchar](150) NOT NULL,
	[authors] [nvarchar](150) NULL,
	[publisher] [nvarchar](150) NULL,
	[bookNumber] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bookNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CirculatedCopy]    Script Date: 8/24/2020 9:13:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CirculatedCopy](
	[copyNumber] [int] NOT NULL,
	[memberNumber] [int] NOT NULL,
	[borrowedDate] [datetime] NOT NULL,
	[dueDate] [datetime] NOT NULL,
	[returnedDate] [datetime] NULL,
	[fineAmount] [money] NULL,
	[circulatedCopyId] [int] IDENTITY(1,1) NOT NULL,
	[numberRenew] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[circulatedCopyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 8/24/2020 9:13:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Copy](
	[bookNumber] [int] NOT NULL,
	[sequenceNumber] [int] NOT NULL,
	[type] [int] NULL,
	[price] [money] NOT NULL,
	[copyNumber] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[copyNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 8/24/2020 9:13:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[name] [nvarchar](150) NOT NULL,
	[sex] [bit] NOT NULL,
	[address] [nvarchar](150) NOT NULL,
	[telephone] [nvarchar](15) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[memberNumber] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[memberNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 8/24/2020 9:13:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[memberNumber] [int] NOT NULL,
	[bookNumber] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[status] [bit] NOT NULL,
	[reservationID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[reservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Book] ON 
GO
INSERT [dbo].[Book] ([title], [authors], [publisher], [bookNumber]) VALUES (N'The Hunger Games', N'Suzanne Collins', N'Scholastic', 1)
GO
INSERT [dbo].[Book] ([title], [authors], [publisher], [bookNumber]) VALUES (N'1984', N'George Orwell', N'ABC Group', 2)
GO
INSERT [dbo].[Book] ([title], [authors], [publisher], [bookNumber]) VALUES (N'Animal Farm', N'George Orwell', N'Unknown Cop', 3)
GO
INSERT [dbo].[Book] ([title], [authors], [publisher], [bookNumber]) VALUES (N'Cosmos', N'Carl Sagan', N'Ballantine Books', 5)
GO
INSERT [dbo].[Book] ([title], [authors], [publisher], [bookNumber]) VALUES (N'Coraline', N'Neil Gaiman', N'ABC Group', 6)
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[CirculatedCopy] ON 
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (1, 1, CAST(N'2020-07-26T08:46:55.410' AS DateTime), CAST(N'2020-08-09T08:46:55.410' AS DateTime), CAST(N'2020-07-26T10:22:39.263' AS DateTime), 0.0000, 14, 0)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (2, 1, CAST(N'2020-07-26T08:46:55.410' AS DateTime), CAST(N'2020-08-09T08:46:55.410' AS DateTime), CAST(N'2020-07-26T10:25:22.043' AS DateTime), 0.0000, 15, 0)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (1, 1, CAST(N'2020-07-26T10:27:24.963' AS DateTime), CAST(N'2020-08-09T10:27:24.963' AS DateTime), CAST(N'2020-07-26T10:27:53.633' AS DateTime), 0.0000, 16, 0)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (2, 1, CAST(N'2020-07-26T10:27:24.963' AS DateTime), CAST(N'2020-08-09T10:27:24.963' AS DateTime), CAST(N'2020-07-26T10:28:39.470' AS DateTime), 0.0000, 17, 0)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (1, 2, CAST(N'2020-07-26T14:51:30.813' AS DateTime), CAST(N'2020-08-09T14:51:30.813' AS DateTime), CAST(N'2020-07-26T14:56:43.533' AS DateTime), 0.0000, 18, 0)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (2, 2, CAST(N'2020-07-26T14:51:30.813' AS DateTime), CAST(N'2020-10-18T14:51:30.813' AS DateTime), NULL, NULL, 19, 3)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (1, 1, CAST(N'2020-07-26T14:57:21.437' AS DateTime), CAST(N'2020-08-09T14:57:21.437' AS DateTime), CAST(N'2020-07-26T21:31:56.470' AS DateTime), 0.0000, 20, 0)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (3, 2, CAST(N'2020-07-26T21:29:53.690' AS DateTime), CAST(N'2020-11-01T21:29:53.690' AS DateTime), NULL, NULL, 21, 3)
GO
INSERT [dbo].[CirculatedCopy] ([copyNumber], [memberNumber], [borrowedDate], [dueDate], [returnedDate], [fineAmount], [circulatedCopyId], [numberRenew]) VALUES (1, 3, CAST(N'2020-07-26T21:35:53.257' AS DateTime), CAST(N'2020-08-23T21:35:53.257' AS DateTime), NULL, NULL, 22, 1)
GO
SET IDENTITY_INSERT [dbo].[CirculatedCopy] OFF
GO
SET IDENTITY_INSERT [dbo].[Copy] ON 
GO
INSERT [dbo].[Copy] ([bookNumber], [sequenceNumber], [type], [price], [copyNumber]) VALUES (1, 1, 1, 50000.0000, 1)
GO
INSERT [dbo].[Copy] ([bookNumber], [sequenceNumber], [type], [price], [copyNumber]) VALUES (1, 2, 1, 50000.0000, 2)
GO
INSERT [dbo].[Copy] ([bookNumber], [sequenceNumber], [type], [price], [copyNumber]) VALUES (2, 1, 1, 70000.0000, 3)
GO
INSERT [dbo].[Copy] ([bookNumber], [sequenceNumber], [type], [price], [copyNumber]) VALUES (2, 2, 0, 75000.0000, 4)
GO
SET IDENTITY_INSERT [dbo].[Copy] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 
GO
INSERT [dbo].[Member] ([name], [sex], [address], [telephone], [email], [memberNumber]) VALUES (N'Nguyen Tuan Ngoc', 1, N'31 Khuong Thuong', N'0336081795', N'ngocnthe141341@fpt.edu.vn', 1)
GO
INSERT [dbo].[Member] ([name], [sex], [address], [telephone], [email], [memberNumber]) VALUES (N'Hoang Thuy Tien', 0, N'52 Thach Hoa', N'0335824852', N'tienkami123@gmail.com', 2)
GO
INSERT [dbo].[Member] ([name], [sex], [address], [telephone], [email], [memberNumber]) VALUES (N'Le Anh Tuan', 1, N'56 Tran Phu', N'0389554555', N'anhtuanlee56@gmail.com', 3)
GO
INSERT [dbo].[Member] ([name], [sex], [address], [telephone], [email], [memberNumber]) VALUES (N'Ha Hong Son', 1, N'Dai Hoc FPT', N'0335614574', N'sonhh123@gmail.com', 4)
GO
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservation] ON 
GO
INSERT [dbo].[Reservation] ([memberNumber], [bookNumber], [date], [status], [reservationID]) VALUES (1, 1, CAST(N'2020-07-26T14:55:54.837' AS DateTime), 1, 1)
GO
INSERT [dbo].[Reservation] ([memberNumber], [bookNumber], [date], [status], [reservationID]) VALUES (3, 1, CAST(N'2020-07-26T21:30:48.783' AS DateTime), 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Reservation] OFF
GO
ALTER TABLE [dbo].[CirculatedCopy]  WITH CHECK ADD FOREIGN KEY([copyNumber])
REFERENCES [dbo].[Copy] ([copyNumber])
GO
ALTER TABLE [dbo].[CirculatedCopy]  WITH CHECK ADD FOREIGN KEY([memberNumber])
REFERENCES [dbo].[Member] ([memberNumber])
GO
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([bookNumber])
REFERENCES [dbo].[Book] ([bookNumber])
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD FOREIGN KEY([bookNumber])
REFERENCES [dbo].[Book] ([bookNumber])
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD FOREIGN KEY([memberNumber])
REFERENCES [dbo].[Member] ([memberNumber])
GO
