﻿// Licence file C:\Users\Veloso\Documents\ReversePOCO.txt not found.
// Please obtain your licence file at www.ReversePOCO.co.uk, and place it in your documents folder shown above.
// Defaulting to Trial version.


// ------------------------------------------------------------------------------------------------
// WARNING: Failed to load provider "System.Data.SqlClient" - Erro de rede ou específico à instância ao estabelecer conexão com o SQL Server. O servidor não foi encontrado ou não estava acessível. Verifique se o nome da instância está correto e se o SQL Server está configurado para permitir conexões remotas. (provider: Named Pipes Provider, error: 40 - Não foi possível abrir uma conexão com o SQL Server)
// Allowed providers:
//    "System.Data.Odbc"
//    "System.Data.OleDb"
//    "System.Data.OracleClient"
//    "System.Data.SqlClient"
//    "Microsoft.SqlServerCe.Client.4.0"

/*   em System.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, SqlCredential credential, Object providerInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString userConnectionOptions, SessionData reconnectSessionData, DbConnectionPool pool, String accessToken, Boolean applyTransientFaultHandling, SqlAuthenticationProviderManager sqlAuthProviderManager)
   em System.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, DbConnectionPoolKey poolKey, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection, DbConnectionOptions userOptions)
   em System.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnectionPool pool, DbConnection owningObject, DbConnectionOptions options, DbConnectionPoolKey poolKey, DbConnectionOptions userOptions)
   em System.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   em System.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   em System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, UInt32 waitForMultipleObjectsTimeout, Boolean allowCreate, Boolean onlyOneCheckConnection, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   em System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   em System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   em System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   em System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   em System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   em System.Data.SqlClient.SqlConnection.Open()
   em Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.DatabaseReader.Init() na C:\Users\Veloso\.netcore\WK\Ef7BaseExistente\EF.Reverse.POCO.v3.ttinclude:linha 12200
   em Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.SqlServerDatabaseReader.Init() na C:\Users\Veloso\.netcore\WK\Ef7BaseExistente\EF.Reverse.POCO.v3.ttinclude:linha 15604
   em Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.Generator.Init(DatabaseReader databaseReader, String singleDbContextSubNamespace) na C:\Users\Veloso\.netcore\WK\Ef7BaseExistente\EF.Reverse.POCO.v3.ttinclude:linha 4138
   em Microsoft.VisualStudio.TextTemplating09131ED12995648E09019BDFAE61E46B0266BAE7C8080D958CBEC12B602BE1C120A6ACE046BBC8778374F00E6AF22D47A4CAE857445E2A701728834021C5B8FC.GeneratedTextTransformation.GeneratorFactory.Create(FileManagementService fileManagementService, Type fileManagerType, String singleDbContextSubNamespace) na C:\Users\Veloso\.netcore\WK\Ef7BaseExistente\EF.Reverse.POCO.v3.ttinclude:linha 6284*/
// ------------------------------------------------------------------------------------------------

