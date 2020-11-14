USE [crs]
GO

/****** Object:  Table [dbo].[department]    Script Date: 2020-01-08 8:08:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[department](
	[department_name] [text] NULL,
	[head_of_department] [text] NULL,
	[budget_limit] [decimal](18, 0) NULL,
	[line_manager] [text] NULL,
	[hod_id] [text] NULL,
	[line_manager_id] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


