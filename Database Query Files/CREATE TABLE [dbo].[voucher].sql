USE [crs]
GO

/****** Object:  Table [dbo].[voucher]    Script Date: 2020-01-08 8:09:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[voucher](
	[voucher_id] [text] NULL,
	[date] [date] NOT NULL,
	[requestor_id] [text] NULL,
	[first_name] [text] NULL,
	[last_name] [text] NULL,
	[phone] [text] NULL,
	[email] [text] NULL,
	[department] [text] NULL,
	[amount] [text] NULL,
	[description_of_items] [text] NULL,
	[manager_approver] [text] NULL,
	[hod_approver] [text] NULL,
	[paid_status] [text] NULL,
	[justification_status] [text] NULL,
	[attachments] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


