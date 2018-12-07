/****** Object:  Table [dbo].[CalLog]    Script Date: 12/7/2018 11:07:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CalLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[A] [int] NULL,
	[B] [int] NULL,
	[KQ] [int] NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_CalLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CalLog] ADD  CONSTRAINT [DF_CalLog_Time]  DEFAULT (getutcdate()) FOR [Time]
GO


/*
Scaffold-DbContext "Server=tcp:9dev.database.windows.net,1433;Initial Catalog=9devlogdb;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir ./LoggerAPI/Models
*/