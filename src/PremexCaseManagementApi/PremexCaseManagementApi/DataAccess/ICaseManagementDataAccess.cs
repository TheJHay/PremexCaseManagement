using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using PremexCaseManagementApi.Models.Entities;

namespace PremexCaseManagementApi.DataAccess
{
    public interface ICaseManagementDataAccess
    {
        Task<int> CreateCase(PremexCase premexCase);
    }

    public class CaseManagementDataAccess : ICaseManagementDataAccess
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private const string CaseManagementDb = "CaseManagementDB";
        private const string InsertCase =
            @"DECLARE @AccidentDate nvarchar(10),
            @AccidentTime nvarchar(5),
            @Injuries ntext,
            @ClientAddress1 nvarchar(75),
            @ClientAddress2 nvarchar(75),
            @ClientAddress3 nvarchar(75),
            @ClientAddress4 nvarchar(75),
            @ClientDOB nvarchar(10),
            @ClientFirstName nvarchar(50),
            @ClientLastName nvarchar(50),
            @ClientPostcode nvarchar(10),
            @ClientTelHome nvarchar(30),
            @ClientTelMob nvarchar(30),
            @ClientTelWork nvarchar(30),
            @ClientTitle nvarchar(20),
            @WorksourceId int;

            INSERT INTO[dbo].[PremexCases]
            ([AccidentDate]
            ,[AccidentTime]
            ,[Injuries]
            ,[ClientAddress1]
            ,[ClientAddress2]
            ,[ClientAddress3]
            ,[ClientAddress4]
            ,[ClientDOB]
            ,[ClientFirstName]
            ,[ClientLastName]
            ,[ClientPostcode]
            ,[ClientTelHome]
            ,[ClientTelMob]
            ,[ClientTelWork]
            ,[ClientTitle]
            ,[WorksourceId])
            OUTPUT Inserted.CaseId
            VALUES
            (
                @AccidentDate,
                @AccidentTime,
                @Injuries,
                @ClientAddress1,
                @ClientAddress2,
                @ClientAddress3,
                @ClientAddress4,
                @ClientDOB,
                @ClientFirstName,
                @ClientLastName,
                @ClientPostcode,
                @ClientTelHome,
                @ClientTelMob,
                @ClientTelWork,
                @ClientTitle,
                @WorksourceId

            )";

        public CaseManagementDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString(CaseManagementDb);
        }

        public async Task<int> CreateCase(PremexCase premexCase)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            using var transaction = db.BeginTransaction();

            var id = await db.QueryFirstAsync<int>(InsertCase, premexCase, transaction: transaction);
            return id;
        }
    }
}