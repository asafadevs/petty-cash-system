USE [crs]
GO

/****** Object:  Table [dbo].[user]    Script Date: 2020-01-08 8:09:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[user](
	[user_id] [text] NULL,
	[first_name] [text] NULL,
	[last_name] [text] NULL,
	[department] [text] NULL,
	[access_level] [text] NULL,
	[phone] [text] NULL,
	[email] [text] NULL,
	[password] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


