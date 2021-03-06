USE [abc]
GO
/****** Object:  Table [dbo].[tbl_invoice_details]    Script Date: 2/7/2022 8:04:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_invoice_details](
	[inv_detail_no] [int] IDENTITY(1,1) NOT NULL,
	[inv_no] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[item_cost_price] [float] NULL,
	[item_price] [float] NULL,
	[item_qty] [float] NULL,
	[sub_total] [float] NULL,
	[uom_id] [int] NULL,
 CONSTRAINT [PK_tbl_invoice_details_1] PRIMARY KEY CLUSTERED 
(
	[inv_detail_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_invoice_master]    Script Date: 2/7/2022 8:04:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_invoice_master](
	[inv_no] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[inv_date] [date] NULL,
	[total_price] [float] NULL,
	[total_qty] [float] NULL,
	[inv_stat] [int] NULL,
	[is_deleted] [bit] NULL,
	[deleted_user_id] [nchar](10) NULL,
	[deleted_date] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_invoice_master_1] PRIMARY KEY CLUSTERED 
(
	[inv_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_item_master]    Script Date: 2/7/2022 8:04:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_item_master](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[item_code] [varchar](250) NULL,
	[item_desc] [varchar](250) NULL,
	[uom_id] [int] NOT NULL,
	[item_price] [float] NULL,
	[item_cost_price] [float] NULL,
	[is_vehicle] [bit] NULL,
	[vehicle_type_desc] [varchar](250) NULL,
	[vehicle_model_desc] [varchar](250) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tbl_item_master_1] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_role_master]    Script Date: 2/7/2022 8:04:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_role_master](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_desc] [varchar](250) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tbl_role_master] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_uom_master]    Script Date: 2/7/2022 8:04:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_uom_master](
	[uom_id] [int] IDENTITY(1,1) NOT NULL,
	[uom_desc] [varchar](250) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tbl_uom_master] PRIMARY KEY CLUSTERED 
(
	[uom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user_master]    Script Date: 2/7/2022 8:04:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user_master](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](250) NULL,
	[password] [varchar](250) NULL,
	[role_id] [int] NOT NULL,
	[f_name] [varchar](250) NULL,
	[l_name] [varchar](250) NULL,
	[address] [varchar](250) NULL,
	[is_active] [bit] NULL,
	[nic_no] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_user_master_1] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_invoice_master] ADD  CONSTRAINT [DF_tbl_invoice_master_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[tbl_item_master] ADD  CONSTRAINT [DF_tbl_item_master_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[tbl_role_master] ADD  CONSTRAINT [DF_tbl_role_master_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[tbl_uom_master] ADD  CONSTRAINT [DF_tbl_uom_master_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[tbl_user_master] ADD  CONSTRAINT [DF_tbl_user_master_is_active]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[tbl_invoice_details]  WITH CHECK ADD  CONSTRAINT [FK_tbl_invoice_details_tbl_invoice_master] FOREIGN KEY([inv_no])
REFERENCES [dbo].[tbl_invoice_master] ([inv_no])
GO
ALTER TABLE [dbo].[tbl_invoice_details] CHECK CONSTRAINT [FK_tbl_invoice_details_tbl_invoice_master]
GO
ALTER TABLE [dbo].[tbl_invoice_details]  WITH CHECK ADD  CONSTRAINT [FK_tbl_invoice_details_tbl_item_master] FOREIGN KEY([item_id])
REFERENCES [dbo].[tbl_item_master] ([item_id])
GO
ALTER TABLE [dbo].[tbl_invoice_details] CHECK CONSTRAINT [FK_tbl_invoice_details_tbl_item_master]
GO
ALTER TABLE [dbo].[tbl_invoice_details]  WITH CHECK ADD  CONSTRAINT [FK_tbl_invoice_details_tbl_uom_master] FOREIGN KEY([uom_id])
REFERENCES [dbo].[tbl_uom_master] ([uom_id])
GO
ALTER TABLE [dbo].[tbl_invoice_details] CHECK CONSTRAINT [FK_tbl_invoice_details_tbl_uom_master]
GO
ALTER TABLE [dbo].[tbl_item_master]  WITH CHECK ADD  CONSTRAINT [FK_tbl_item_master_tbl_uom_master] FOREIGN KEY([uom_id])
REFERENCES [dbo].[tbl_uom_master] ([uom_id])
GO
ALTER TABLE [dbo].[tbl_item_master] CHECK CONSTRAINT [FK_tbl_item_master_tbl_uom_master]
GO
ALTER TABLE [dbo].[tbl_user_master]  WITH CHECK ADD  CONSTRAINT [FK_tbl_user_master_tbl_role_master] FOREIGN KEY([role_id])
REFERENCES [dbo].[tbl_role_master] ([role_id])
GO
ALTER TABLE [dbo].[tbl_user_master] CHECK CONSTRAINT [FK_tbl_user_master_tbl_role_master]
GO
