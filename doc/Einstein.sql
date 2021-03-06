SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuAuthInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MenuAuthInfo](
	[ButtonID] [int] IDENTITY(1,1) NOT NULL,
	[BelongMenu] [nvarchar](50) NOT NULL,
	[ButtonName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MenuAuthInfo] PRIMARY KEY CLUSTERED 
(
	[ButtonID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleUserInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoleUserInfo](
	[RoleID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_RoleUserInfo] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[UserID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleAuth]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoleAuth](
	[RoleID] [int] NOT NULL,
	[MenuID] [nvarchar](50) NOT NULL,
	[ButtonID] [int] NOT NULL,
 CONSTRAINT [PK_RoleAuth] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[MenuID] ASC,
	[ButtonID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MechineInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MechineInfo](
	[MechineID] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](100) NULL,
	[ManageDeptID] [int] NOT NULL,
	[MachineTypeID] [int] NOT NULL,
	[CommunicationInterface] [int] NOT NULL,
	[IPAdress] [nvarchar](50) NULL,
	[SubnetMask] [nvarchar](50) NULL,
	[Gateway] [nvarchar](50) NULL,
	[Port] [int] NULL,
	[Desc] [nvarchar](50) NULL,
 CONSTRAINT [PK_MechineInfo] PRIMARY KEY CLUSTERED 
(
	[MechineID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MachineManageInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MachineManageInfo](
	[ManageDeptID] [int] NOT NULL,
	[ManageDeptName] [nvarchar](50) NOT NULL,
	[ParentID] [int] NOT NULL,
 CONSTRAINT [PK_MachineManageInfo] PRIMARY KEY CLUSTERED 
(
	[ManageDeptID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CardInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CardInfo](
	[CardID] [varchar](50) NOT NULL,
	[PhysicalID] [varchar](50) NULL,
	[Status] [int] NOT NULL,
	[ActivateDate] [datetime] NULL,
	[ActivatePerson] [nvarchar](50) NULL,
	[CancelDate] [datetime] NULL,
	[CancelPerson] [nvarchar](50) NULL,
 CONSTRAINT [PK_CardInfo] PRIMARY KEY CLUSTERED 
(
	[CardID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeptInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DeptInfo](
	[DeptID] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[ParentID] [int] NOT NULL,
	[Desc] [nvarchar](50) NULL,
 CONSTRAINT [PK_DeptInfo] PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserTypeInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserTypeInfo](
	[UserTypeID] [int] IDENTITY(1,1) NOT NULL,
	[UserTypeName] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserTypeInfo] PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserInfo](
	[UserID] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[DeptID] [int] NOT NULL,
	[CardID] [nvarchar](50) NULL,
	[PhysicalID] [nvarchar](50) NULL,
	[UserTypeID] [int] NULL,
	[Sex] [int] NOT NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[ActivateDate] [datetime] NOT NULL,
	[CancelDate] [datetime] NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SystemLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Operator] [nvarchar](50) NOT NULL,
	[OperateTime] [datetime] NOT NULL,
	[Detail] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_SystemLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日志编号' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'SystemLog', @level2type=N'COLUMN', @level2name=N'ID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'SystemLog', @level2type=N'COLUMN', @level2name=N'Operator'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时间' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'SystemLog', @level2type=N'COLUMN', @level2name=N'OperateTime'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'详细' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'SystemLog', @level2type=N'COLUMN', @level2name=N'Detail'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoleInfo](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](500) NULL,
	[CreatePerson] [nvarchar](50) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdatePerson] [nvarchar](50) NULL,
	[UpdateTime] [datetime] NULL,
 CONSTRAINT [PK_RoleInfo] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MenuInfo](
	[MenuID] [nvarchar](50) NOT NULL,
	[MenuName] [nvarchar](10) NOT NULL,
	[ParentID] [nvarchar](50) NOT NULL,
	[ShortcutKey] [char](1) NULL,
	[IconName] [nvarchar](50) NULL,
	[ObjectName] [nvarchar](50) NULL,
	[ObjectParameters] [nvarchar](100) NULL,
 CONSTRAINT [PK_MenuInfo] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
