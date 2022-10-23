BEGIN TRANSACTION;
GO

ALTER TABLE [MyProperty] DROP CONSTRAINT [PK_MyProperty];
GO

EXEC sp_rename N'[MyProperty]', N'People';
GO

ALTER TABLE [People] ADD CONSTRAINT [PK_People] PRIMARY KEY ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221022150410_UpdateFirstMigration_Mig', N'6.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Password', N'UserName') AND [object_id] = OBJECT_ID(N'[People]'))
    SET IDENTITY_INSERT [People] ON;
INSERT INTO [People] ([Id], [Password], [UserName])
VALUES (1, N'1234', N'Admin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Password', N'UserName') AND [object_id] = OBJECT_ID(N'[People]'))
    SET IDENTITY_INSERT [People] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221022175838_InsertData_Mig', N'6.0.10');
GO

COMMIT;
GO

