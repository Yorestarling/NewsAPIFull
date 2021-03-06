USE [NewsAPIside]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[descriptions] [nvarchar](max) NULL,
	[ulr] [nvarchar](max) NULL,
	[ulrToImage] [nvarchar](max) NULL,
	[PublishedAt] [datetime] NULL,
	[Content] [nvarchar](max) NULL,
	[SourcesId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CountriesId] [int] NOT NULL,
 CONSTRAINT [PK_ArticleId] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[UsersId] [int] NOT NULL,
	[AuthorName] [varchar](60) NOT NULL,
 CONSTRAINT [PK_AuthorId] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_CategoryId] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountriesId] [int] IDENTITY(1,1) NOT NULL,
	[ContriesName] [varchar](70) NOT NULL,
 CONSTRAINT [PK_CountriesId] PRIMARY KEY CLUSTERED 
(
	[CountriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sources]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sources](
	[SourcesId] [int] IDENTITY(1,1) NOT NULL,
	[SourcesName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_SourcesId] PRIMARY KEY CLUSTERED 
(
	[SourcesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersLog]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersLog](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [varchar](250) NOT NULL,
	[Username] [varchar](40) NOT NULL,
	[Passwords] [varchar](400) NOT NULL,
 CONSTRAINT [PK_UserId] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (1, 1, N'Nationals Reinstate Three From COVID List; Designate Jonathan Lucroy For Assignment - MLB Trade Rumors', N'The Nationals announced a series of roster moves as they continue to bring players back from the COVID-19 list.  Josh &hellip;', N'https://www.mlbtraderumors.com/2021/04/nationals-reinstate-three-from-covid-list-designate-jonathan-lucroy-for-assignment.html', N'https://cdn.mlbtraderumors.com/files/2020/10/josh-harrison-nationals-1024x682.jpg', CAST(N'2021-04-13T00:00:00.000' AS DateTime), N'The Nationals announced a series of roster moves as they continue to bring players back from the COVID-19 list.  Josh Bell, Kyle Schwarber, and Josh Harrison are all back from COVID protocols and are… ', 1, 4, 51)
INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (2, 2, N'21.04 nvidia-smi: no device found', N'I am using intel integrated gpu (10600k). Ubuntu 20.04 didn''t work with intel iGPU for some reason. Only fix found was to use 21.04. Apparently you need linux kernel 5.11 for it to work... 21.04 ships with that by default.\nNow, I installed nvidia drivers 460 …', N'"https://askubuntu.com/questions/1351008/21-04-nvidia-smi-no-device-found', N'https://cdn.sstatic.net/Sites/askubuntu/Img/apple-touch-icon@2.png?v=c492c9229955', CAST(N'2021-07-07T19:16:00.000' AS DateTime), N'I am using intel integrated gpu (10600k). Ubuntu 20.04 didn''t work with intel iGPU for some reason. Only fix found was to use 21.04. Apparently you need linux kernel 5.11 for it to work...', 2, 1, 51)
INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (3, 3, N'PUBG Mobile now lets players build a self-driving Tesla Model Y', N'The most recent PUBG Mobile update introduces a new collaboration with Tesla that will allow players on both Android and iOS devices to build their own self-driving vehicles.', N'"https://www.phonearena.com/news/pubg-mobile-update-self-driving-tesla-car_id133519', N'https://image.cnbcfm.com/api/v1/image/103507383-Lightning-Round.jpg?v=1459356509', CAST(N'2021-07-12T21:14:00.000' AS DateTime), N'PUBG has been very successful on both PC and mobile, which is why it''s been fiercely supported by developers with many updates that add interesting collaborations with major brands, as well as import&hellip;', 3, 3, 51)
INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (4, 4, N'ASX lithium shares are surging on Tuesday. Here’s why', N'It''s a good day on the charts for ASX lithium shares today. Let''s take a closer look.\nThe post ASX lithium shares are surging on Tuesday. Here’s why appeared first on The Motley Fool Australia.', N'"https://www.fool.com.au/2021/07/13/asx-lithium-shares-are-surging-on-tuesday-heres-why/', N'https://www.fool.com.au/wp-content/uploads/2021/01/lithium.jpg', CAST(N'2021-07-13T02:04:00.000' AS DateTime), N'ASX lithium shares are surging today following a strong overnight rally in lithium-related peers on Wall Street. \r\nHigh-profile overseas lithium players, including global chemical manufacturer and li&hellip;', 4, 5, 53)
INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (5, 5, N'Eka Ventures closes $95M Impact VC fund for sustainable consumption, healthcare and society', N'It’s clear that there is an enormous and growing appetite amongst consumers to switch to products and services which address some of the biggest issues of our era, whether it be climate change or problems with society. So we’ve seen the rise of ethical invest…', N'http://techcrunch.com/2021/07/12/eka-ventures-closes-95m-impact-vc-fund-for-sustainable-consumption-healthcare-and-society/', N'https://techcrunch.com/wp-content/uploads/2021/07/Eka.jpg?w=764', CAST(N'2021-07-13T02:06:00.000' AS DateTime), N'Its clear that there is an enormous and growing appetite amongst consumers to switch to products and services which address some of the biggest issues of our era, whether it be climate change or prob&hellip;', 5, 7, 54)
INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (6, 6, N'US earnings season: the most anticipated stocks', N'SPONSORED: What can you potentially expect from some of the hottest US stocks?', N'"https://www.stuff.co.nz/business/money/125736420/us-earnings-season-the-most-anticipated-stocks', N'https://resources.stuff.co.nz/content/dam/images/2/2/u/y/v/7/image.related.StuffLandscapeSixteenByNine.1420x800.22uyuc.png/1626328777025.jpg', CAST(N'2021-07-15T06:06:00.000' AS DateTime), N'Financial services firm CMC Markets takes a look at the US stock market and the most anticipated companies this earnings season.\r\n Earnings season has kicked off in the US, with results from many lar&hellip;', 6, 2, 51)
INSERT [dbo].[Articles] ([ArticleId], [AuthorId], [Title], [descriptions], [ulr], [ulrToImage], [PublishedAt], [Content], [SourcesId], [CategoryId], [CountriesId]) VALUES (7, 7, N'Tesla upgrade takes Superchargers to 300kW Musk confirms: What to know', N'Tesla’s Supercharger network is getting a potency upgrade, with Elon Musk confirming the maximum charging rate is going to increase. The new upgrade will take Superchargers from 250 kW to 300 kW, Musk revealed on Twitter, having hinted that power increases we…', N' https://www.slashgear.com/tesla-upgrade-takes-superchargers-to-300kw-musk-confirms-what-to-know-15682575/', N' https://cdn.slashgear.com/wp-content/uploads/2021/07/tesla-supercharger.jpeg', CAST(N'2021-07-15T12:03:00.000' AS DateTime), N'Tesla&rsquo;s Supercharger network is getting a potency upgrade, with Elon Musk confirming the maximum charging rate is going to increase. The new upgrade will take Superchargers from 250 kW to 300 kW, Mus&hellip;', 7, 2, 5)
SET IDENTITY_INSERT [dbo].[Articles] OFF
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (1, 1, N'Mark Polishuk')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (2, 2, N'Mooder')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (3, 3, N'Cosmin Vasile')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (4, 4, N'Kerry Sun')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (5, 5, N'Mike Butcher')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (6, 6, N'CMC MARKETS')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (7, 7, N'Chris Davies')
INSERT [dbo].[Authors] ([AuthorId], [UsersId], [AuthorName]) VALUES (8, 8, N'Devik Jain')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'General')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Business')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Entertainment')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Health')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Science')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (6, N'Sports')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (7, N'Technology')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (1, N'Austria')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (2, N'Belgium')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (3, N'Brazil')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (4, N'Bulgaria')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (5, N'Canada')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (6, N'China')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (7, N'Colombia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (8, N'Cuba')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (9, N'Czech Republic')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (10, N'Egypt')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (11, N'France')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (12, N'Germany')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (13, N'Greece')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (14, N'Hong Kong')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (15, N'Hungary')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (16, N'India')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (17, N'Indonesia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (18, N'Ireland')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (19, N'Israel')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (20, N'Italy')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (21, N'Japan')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (22, N'Latvia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (23, N'Lithuania')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (24, N'Malaysia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (25, N'Mexico')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (26, N'Morocco')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (27, N'Netherlands')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (28, N'New Zealand')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (29, N'Nigeria')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (30, N'Norway')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (31, N'Philippines')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (32, N'Poland')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (33, N'Portugal')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (34, N'Romania')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (35, N'Russian Federation')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (36, N'Saudi Arabia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (37, N'Serbia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (38, N'Singapore')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (39, N'Slovakia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (40, N'Slovenia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (41, N'South Africa')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (42, N'Korea')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (43, N'Sweden')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (44, N'Switzerland')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (45, N'Taiwan')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (46, N'Thailand')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (47, N'Turkey')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (48, N'Ukraine')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (49, N'United Arab Emirates')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (50, N'United Kingdom of Great Britain and Northern Ireland')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (51, N'United States of America')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (52, N'Venezuela')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (53, N'Australia')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (54, N'Dominican Republic')
INSERT [dbo].[Countries] ([CountriesId], [ContriesName]) VALUES (55, N'Puerto Rico')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Sources] ON 

INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (1, N'CNN')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (2, N'BBC News')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (3, N'Phone Arena')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (4, N'Motley Fool Australia')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (5, N'TechCrunch')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (6, N'Stuff.co.nz')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (7, N'SlashGear')
INSERT [dbo].[Sources] ([SourcesId], [SourcesName]) VALUES (8, N'reuters')
SET IDENTITY_INSERT [dbo].[Sources] OFF
GO
SET IDENTITY_INSERT [dbo].[UsersLog] ON 

INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (1, N'Admin 1', N'Admin1', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (2, N'Admin 2', N'Admin2', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (3, N'Admin 3', N'Admin3', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (4, N'Admin 4', N'Admin4', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (5, N'Admin 5', N'Admin5', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (6, N'Admin 6', N'Admin6', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (7, N'Admin 7', N'Admin7', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
INSERT [dbo].[UsersLog] ([UserId], [DisplayName], [Username], [Passwords]) VALUES (8, N'Admin 8', N'Admin8', N'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC')
SET IDENTITY_INSERT [dbo].[UsersLog] OFF
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_AuthorIds] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_AuthorIds]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_CategoryId]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_CountriesId] FOREIGN KEY([CountriesId])
REFERENCES [dbo].[Countries] ([CountriesId])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_CountriesId]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_SourcesIds] FOREIGN KEY([SourcesId])
REFERENCES [dbo].[Sources] ([SourcesId])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_SourcesIds]
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD  CONSTRAINT [FK_UserId] FOREIGN KEY([UsersId])
REFERENCES [dbo].[UsersLog] ([UserId])
GO
ALTER TABLE [dbo].[Authors] CHECK CONSTRAINT [FK_UserId]
GO
/****** Object:  StoredProcedure [dbo].[UsersInsert]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UsersInsert]
@displayName Varchar(250),
@UserName Varchar(40),
@Password Varchar(400)
as begin
	set @Password = CONVERT(VARCHAR(MAX),hashbytes('SHA2_512',@password),2)

	insert UsersLog(DisplayName,Username,Passwords)
		values(@displayName,@UserName,@Password)
end
GO
/****** Object:  StoredProcedure [dbo].[UsersValidate]    Script Date: 8/8/2021 7:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UsersValidate]
	@username varchar(40), @password varchar(400)
	as begin
		
		set @Password = CONVERT(
		VARCHAR(MAX),
		hashbytes('SHA2_512',@password),2)

		select * from UsersLog where Username = @username 
		and Passwords = @password
	end
GO
