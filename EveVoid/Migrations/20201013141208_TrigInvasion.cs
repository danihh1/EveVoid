using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class TrigInvasion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete Stargates where DestinationId in 
                (
                select id from Stargates where systemid in 
                (30000021,30000157,30000192,30000206,30001372,30001381,30001413,30001445,30002079,30002225,30002411,30002652,30002702,30002737,30002770,30002797,30003046,30003495,
                30003504,30005005,30005029,30010141,30020141,30031392,30040141,30045328,30045329))
                 or id in (select id from Stargates where systemid in 
                (30000021,30000157,30000192,30000206,30001372,30001381,30001413,30001445,30002079,30002225,30002411,30002652,30002702,30002737,30002770,30002797,30003046,30003495,
                30003504,30005005,30005029,30010141,30020141,30031392,30040141,30045328,30045329))");

            migrationBuilder.Sql(@"delete [EveVoid].[dbo].[AdjacencyMatrix]
                where RowNumber in (30000021,30000157,30000192,30000206,30001372,30001381,30001413,30001445,30002079,30002225,30002411,30002652,30002702,30002737,30002770,30002797,30003046,30003495,
                30003504,30005005,30005029,30010141,30020141,30031392,30040141,30045328,30045329)
                or ColumnNumber in (30000021,30000157,30000192,30000206,30001372,30001381,30001413,30001445,30002079,30002225,30002411,30002652,30002702,30002737,30002770,30002797,30003046,30003495,
                30003504,30005005,30005029,30010141,30020141,30031392,30040141,30045328,30045329)");

            migrationBuilder.Sql(@"update SolarSystems set LastUpdate = '2020-01-01' where id in
                (30000021,30000157,30000192,30000206,30001372,30001381,30001413,30001445,30002079,30002225,30002411,30002652,30002702,30002737,30002770,30002797,30003046,30003495,
                30003504,30005005,30005029,30010141,30020141,30031392,30040141,30045328,30045329)");

            migrationBuilder.Sql(@"insert into SystemTypes (Name
                ,Color)
	            values ('Trig', '#ff4800')");

            migrationBuilder.Sql(@"update SolarSystems 
                set systemTypeId = (select id from systemTypes where name like 'Trig')
                where id in
                (30000021,30000157,30000192,30000206,30001372,30001381,30001413,30001445,30002079,30002225,30002411,30002652,30002702,30002737,30002770,30002797,30003046,30003495,
                30003504,30005005,30005029,30010141,30020141,30031392,30040141,30045328,30045329)");

            migrationBuilder.Sql(@"declare @trigSysType int;
                set @trigSysType = (select id from systemTypes where name like 'Trig');
                insert into WormholeTypes (Name, Description, MaxMass, MaxJump, LeadsToId, Duration)
                values 
                ('C729', null, 1000000000, 300000000, @trigSysType, '16 Hours'),
                ('X450', null, 1000000000, 300000000, @trigSysType, '16 Hours'),
                ('F216', null, 1000000000, 300000000, @trigSysType, '16 Hours'),
                ('U372', null, 1000000000, 300000000, @trigSysType, '16 Hours'),
                ('R081', null, 1000000000, 300000000, @trigSysType, '16 Hours'),
                ('N944', null, 1000000000, 300000000, @trigSysType, '16 Hours')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
