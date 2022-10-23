CREATE TABLE [People] (
    [Id] int NOT NULL IDENTITY,
    [UserName] nvarchar(20) NOT NULL,
    [Password] nvarchar(10) NOT NULL,
    CONSTRAINT [PK_People] PRIMARY KEY ([Id])
);
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Password', N'UserName') AND [object_id] = OBJECT_ID(N'[People]'))
    SET IDENTITY_INSERT [People] ON;
INSERT INTO [People] ([Id], [Password], [UserName])
VALUES (1, N'1234', N'Admin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Password', N'UserName') AND [object_id] = OBJECT_ID(N'[People]'))
    SET IDENTITY_INSERT [People] OFF;
GO


