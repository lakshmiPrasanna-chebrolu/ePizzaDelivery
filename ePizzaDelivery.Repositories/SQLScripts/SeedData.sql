GO
SET IDENTITY_INSERT[dbo].[Categories] ON
GO
INSERT [dbo].[Categories]([Id],[Name],[Description]) VALUES(1,N'Pizza',N'Pizza')
GO
GO
INSERT [dbo].[Categories]([Id],[Name],[Description]) VALUES(2,N'Dessert',N'Dessert')
GO
GO
INSERT [dbo].[Categories]([Id],[Name],[Description]) VALUES(3,N'Beverages',N'Beverages')
GO
SET IDENTITY_INSERT[dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemTypes] ON
GO
INSERT[dbo].[ItemTypes]([Id],[Name]) VALUES (1,N'Veg')
GO
INSERT[dbo].[ItemTypes]([Id],[Name]) VALUES (2,N'NonVeg')
GO
SET IDENTITY_INSERT[dbo].[ItemTypes] OFF
-------------------------------------------------

SET IDENTITY_INSERT[dbo].[AspNetRoles] ON
GO
INSERT [dbo].[AspNetRoles]([Id],[Description],[Name],[NormalizedName],[ConcurrencyStamp])
Values(1,N'Admin',N'Admin',N'Admin',N'979797')
GO
INSERT [dbo].[AspNetRoles]([Id],[Description],[Name],[NormalizedName],[ConcurrencyStamp])
Values(2,N'User',N'User',N'User',N'9797979')
GO
SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF
GO

