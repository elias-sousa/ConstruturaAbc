using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorretoraAbc.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cotacoes",
                columns: table => new
                {
                    IdCotacao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Abertura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Alta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Baixa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fechamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechamentoAjustado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacoes", x => x.IdCotacao);
                    table.ForeignKey(
                        name: "FK_Cotacoes_Acoes_AcaoId",
                        column: x => x.AcaoId,
                        principalTable: "Acoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acoes",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[] { new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), "Magazine Luiza S.A.", "MGLU3.SA" });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("ceb1c610-ff7c-44f9-a860-b0858ce41e91"), 5.638125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.812187m, 5.594687m, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.812187m, 5.641579m, 27017600 },
                    { new Guid("90c2779a-b2e7-44f3-899d-7f35245bcea5"), 10.875000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.370000m, 10.810000m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.255000m, 10.970451m, 44655600 },
                    { new Guid("9d91ee93-958a-435a-b493-94db7aba68fe"), 10.877500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.197500m, 10.737500m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.952500m, 10.675598m, 42558800 },
                    { new Guid("a9cfad3b-2d21-467d-a4bb-dc4458d9296d"), 11.402500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.475000m, 11.040000m, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.050000m, 10.770633m, 39114800 },
                    { new Guid("f7c5922a-e62c-4109-874c-cee14fcbfdd8"), 11.125000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.325000m, 10.872500m, new DateTime(2019, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.300000m, 11.014312m, 47176000 },
                    { new Guid("0f0427ce-7559-4a64-8cc7-975e265b71c1"), 11.330000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.570000m, 10.880000m, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.010000m, 10.731645m, 72748800 },
                    { new Guid("9203306f-ee9e-4225-bae2-f010264dd4c8"), 12.035000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.197500m, 11.192500m, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.242500m, 10.958266m, 125373600 },
                    { new Guid("ef8ff5df-20e3-4a21-96b7-e75c6cd3540e"), 11.237500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.825000m, 11.227500m, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.797500m, 11.499234m, 92438400 },
                    { new Guid("867d4db2-a0e8-4736-9e7e-9a69a74a1f0a"), 11.300000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.365000m, 10.767500m, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.850000m, 10.575689m, 65437200 },
                    { new Guid("884100a7-3a55-431f-8155-c8b701275293"), 10.837500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.160000m, 10.642500m, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.160000m, 10.877851m, 95930400 },
                    { new Guid("5ee3a90b-da3c-43b6-b1c8-3f6dc433033a"), 10.795000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.847500m, 10.157500m, new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.287500m, 10.027411m, 49930800 },
                    { new Guid("5ebb2ae5-0359-4e3b-a40d-29eac6bc901a"), 10.550000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.795000m, 10.512500m, new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.667500m, 10.397802m, 42348000 },
                    { new Guid("b34fd6ed-b03a-408f-bfc6-4fdc89fa354d"), 10.845000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.875000m, 10.500000m, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.500000m, 10.234539m, 32608400 },
                    { new Guid("e8e31001-541b-4daa-bda2-1f05b9dd73b6"), 10.872500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.987500m, 10.790000m, new DateTime(2019, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.812500m, 10.539137m, 23944400 },
                    { new Guid("d84620bf-d993-44f3-9368-a28dcc84f05c"), 10.897500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.997500m, 10.730000m, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.872500m, 10.597620m, 32365600 },
                    { new Guid("06254e78-0e49-45c2-a7d1-d5d9e2973d29"), 10.797500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.995000m, 10.792500m, new DateTime(2019, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.930000m, 10.653667m, 23985600 },
                    { new Guid("73f799d0-9f19-4e02-acfb-2ff8e78a35e1"), 10.837500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.887500m, 10.605000m, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.775000m, 10.502585m, 24721600 },
                    { new Guid("5a2a9078-7b62-4482-a8cd-85f91aefcc89"), 10.715000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.110000m, 10.562500m, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.005000m, 10.726769m, 128373200 },
                    { new Guid("9db70cfa-9aa7-4246-b07b-bae5e5d4d611"), 10.860000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.987500m, 10.587500m, new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.750000m, 10.478217m, 28584400 },
                    { new Guid("b30554a7-e92e-49ff-95dd-14ee9f578552"), 10.715000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.720000m, 10.425000m, new DateTime(2019, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.625000m, 10.356378m, 91291200 },
                    { new Guid("30bf7c77-5691-4263-85d8-8aa79f2218f6"), 11.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.297500m, 10.942500m, new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.245000m, 10.960704m, 110621200 },
                    { new Guid("4fd5bce9-4657-4f82-ad96-2f0213e2948b"), 11.720000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.975000m, 11.662500m, new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.895000m, 11.594270m, 45071600 },
                    { new Guid("ae271c4b-fea1-4e94-b33c-e566439738dc"), 11.485000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.650000m, 11.325000m, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.650000m, 11.355463m, 33751600 },
                    { new Guid("2bbb2d66-213f-4751-80ab-f62a58c97465"), 11.350000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.625000m, 11.330000m, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.462500m, 11.172703m, 51046000 },
                    { new Guid("c9f09172-0424-4e49-a5c2-29505f2ad6ae"), 11.255000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.397500m, 11.200000m, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.350000m, 11.063050m, 30212800 },
                    { new Guid("38a4400c-8104-4675-8f80-88fd4f657a00"), 11.070000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.297500m, 11.017500m, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.222500m, 10.938771m, 39038400 },
                    { new Guid("b180d7fe-d696-473f-a32b-b0b84a95a992"), 11.175000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.437500m, 11.000000m, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.017500m, 10.738955m, 58363600 },
                    { new Guid("85d8e047-a041-4a76-82e8-1faaa07d0378"), 11.297500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.302500m, 11.000000m, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.147500m, 10.865669m, 34445600 },
                    { new Guid("f18f3672-78ce-44f7-8aee-f85e6ddb20eb"), 10.675000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.115000m, 10.642500m, new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.062500m, 10.782818m, 72272400 },
                    { new Guid("bf84806b-8d52-40dc-b4a3-b411a3752af5"), 11.362500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.412500m, 11.130000m, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.230000m, 10.946081m, 39413200 },
                    { new Guid("98a1dbc1-93c1-4f40-996d-81227fdeab5c"), 11.332500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.512500m, 11.207500m, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.400000m, 11.111783m, 48190000 },
                    { new Guid("eabc1f8e-4f4d-486d-b08b-3eb69119b247"), 10.862500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.400000m, 10.800000m, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.400000m, 11.111783m, 65134000 },
                    { new Guid("ce55a53b-e49b-446f-93b8-237dfaf11911"), 11.050000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.072500m, 10.627500m, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.760000m, 10.487964m, 71944400 },
                    { new Guid("a1132233-2863-4391-affb-5db74ac5165d"), 11.375000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.377500m, 11.075000m, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.075000m, 10.795001m, 36308000 },
                    { new Guid("8dd28479-8bb4-403a-a38b-20197a7d1480"), 11.175000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.422500m, 11.140000m, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.372500m, 11.084981m, 47984000 },
                    { new Guid("400e8ee5-dcae-4d61-80bd-b504484e2152"), 11.222500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.272500m, 11.062500m, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.250000m, 10.965576m, 42849600 },
                    { new Guid("bcd1ff67-57b0-4d36-b518-1ffbed5734c0"), 11.245000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.312500m, 10.882500m, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.130000m, 10.848610m, 59731600 },
                    { new Guid("9c0b6b37-f936-4598-bf2d-a011b8cf7a14"), 11.450000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.477500m, 11.257500m, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.257500m, 10.972886m, 45510400 },
                    { new Guid("76e8cf55-2a7a-412e-bb75-2e2d5154c655"), 11.990000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.092500m, 11.882500m, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.957500m, 11.655189m, 36261600 },
                    { new Guid("63b102f2-e804-40d3-86da-301198cfd0a3"), 10.675000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.087500m, 10.650000m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.792500m, 10.519643m, 53416000 },
                    { new Guid("7b7c4bee-381e-454c-b571-f19c114a9932"), 10.550000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.700000m, 10.307500m, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.450000m, 10.185802m, 38353200 },
                    { new Guid("55b3be54-eb07-45fc-aea0-6239d1cd9300"), 8.450000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.717500m, 8.192500m, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.717500m, 8.480815m, 42700800 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("e500fa04-af5d-4724-a9a2-f8894b20113a"), 8.805000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.817500m, 8.512500m, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.525000m, 8.293542m, 31115200 },
                    { new Guid("0b00b3bf-9e51-4a8a-8f78-66253ae81ad2"), 8.750000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.847500m, 8.470000m, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.750000m, 8.512433m, 50517200 },
                    { new Guid("eb93229e-9e60-4f3a-b755-bdc44687cfc1"), 8.425000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.662500m, 8.287500m, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.650000m, 8.415149m, 65658000 },
                    { new Guid("9fa2868d-aae3-4d60-ad6c-fab6c333ac77"), 8.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.327500m, 7.907500m, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.125000m, 7.904402m, 96050400 },
                    { new Guid("5ba02df5-c581-4a3d-8489-86a2040aeaa8"), 9.022500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.040000m, 8.377500m, new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.550000m, 8.317863m, 57427200 },
                    { new Guid("9e06f11d-0cb8-45f5-b4f2-609c86994d68"), 9.245000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.265000m, 8.962500m, new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.000000m, 8.755645m, 31526400 },
                    { new Guid("2f211ff2-e131-4f23-b02e-824c7675b6ba"), 8.535000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.795000m, 8.457500m, new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.712500m, 8.475951m, 41455600 },
                    { new Guid("a4b32533-4fce-4d28-b4d2-f9579f136cc3"), 9.375000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.447500m, 9.162500m, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.175000m, 8.925894m, 28631600 },
                    { new Guid("962bb13c-2d28-4233-af05-906fe36cd7c5"), 9.070000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.345000m, 8.945000m, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.970000m, 8.726461m, 29592000 },
                    { new Guid("225f764f-774c-4469-9ac2-5aeec484d35f"), 9.125000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.235000m, 9.020000m, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.152500m, 8.904007m, 27328800 },
                    { new Guid("99bcdf12-12c0-4cea-bbbe-9b2b8de5fbc1"), 9.400000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.482500m, 8.977500m, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.072500m, 8.826178m, 44445600 },
                    { new Guid("34b1b16c-79e7-4567-a5ae-2677b0031260"), 8.897500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.315000m, 8.837500m, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.315000m, 9.062093m, 55866000 },
                    { new Guid("03d8e671-10aa-4e31-b0d9-8d19f7233f39"), 8.502500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.745000m, 8.375000m, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.727500m, 8.490545m, 44195600 },
                    { new Guid("8efa4923-394c-44c3-abdd-0a22be11294f"), 8.565000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.732500m, 8.455000m, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.552500m, 8.320294m, 52060400 },
                    { new Guid("3ccb1dcb-f4b2-4780-9e49-14d7785190a2"), 8.712500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.750000m, 8.312500m, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.425000m, 8.196259m, 38613600 },
                    { new Guid("ce008417-852e-4ac5-9166-1b57ab8ccc49"), 9.165000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.300000m, 9.087500m, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.300000m, 9.047503m, 31424800 },
                    { new Guid("0031a210-ab37-43f4-8f03-f5d5f921d598"), 10.402500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.720000m, 10.242500m, new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.690000m, 10.419733m, 41211200 },
                    { new Guid("38aa2f5f-a736-4a34-ade5-6d71a31fdb8c"), 8.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.800000m, 8.612500m, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.765000m, 8.527027m, 25575200 },
                    { new Guid("1f921f3b-f866-4406-8bf2-88861b75b9fc"), 8.985000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.140000m, 8.862500m, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.140000m, 8.891845m, 42718400 },
                    { new Guid("d2a0b1b2-da8b-4b58-9d72-bdcce0e16bc7"), 10.000000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.542500m, 9.975000m, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.542500m, 10.275963m, 44124800 },
                    { new Guid("4853cdb2-8bbe-4955-b2d8-c19921109587"), 9.870000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.187500m, 9.840000m, new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.125000m, 9.869020m, 43940800 },
                    { new Guid("2503b94b-3b04-4e70-91d0-ad1535b520d4"), 9.925000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.995000m, 9.700000m, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.735000m, 9.488878m, 30410400 },
                    { new Guid("df187346-60ec-4dfc-b3ac-e5b91e1fe400"), 9.575000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.920000m, 9.570000m, new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.912500m, 9.661892m, 35893600 },
                    { new Guid("0b25c84e-7209-438a-ab2e-c0d7deecb045"), 9.660000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.742500m, 9.465000m, new DateTime(2019, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.500000m, 9.259819m, 42653200 },
                    { new Guid("26ddbbce-1f89-431a-971a-7fdf194bc5fb"), 9.650000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.937500m, 9.540000m, new DateTime(2019, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.600000m, 9.339356m, 39637200 },
                    { new Guid("0b4764d7-e9bc-4976-972d-1cf57e41384d"), 9.350000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.730000m, 9.325000m, new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.695000m, 9.431776m, 59760000 },
                    { new Guid("f451c746-c904-4d0b-b079-c2835cf0c1f8"), 8.850000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.087500m, 8.850000m, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.952500m, 8.709436m, 46304000 },
                    { new Guid("646a59a6-e761-49f2-938b-8439ecad8c61"), 9.140000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.325000m, 9.012500m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.325000m, 9.071821m, 23190000 },
                    { new Guid("a7abcba6-46e0-44a3-b18f-bde67ec18960"), 9.287500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.362500m, 9.177500m, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.362500m, 9.108305m, 25854800 },
                    { new Guid("756daa0e-d3b3-4680-987f-f0cddc551bcf"), 9.187500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.305000m, 9.135000m, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.260000m, 9.008588m, 20688400 },
                    { new Guid("979819ee-7518-49a5-a6dd-c715d41ef920"), 9.140000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.210000m, 9.037500m, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.200000m, 8.950214m, 16346400 },
                    { new Guid("060c82b7-a436-4a35-b4af-93abb34e822a"), 9.202500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.317500m, 9.127500m, new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.142500m, 8.894277m, 27740400 },
                    { new Guid("28ab2fb4-d347-469c-b1f3-3801ea058eb3"), 9.137500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.217500m, 8.937500m, new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.180000m, 8.930758m, 22660800 },
                    { new Guid("7efa78f4-bdec-429e-9ef4-d3873d5fcc92"), 9.025000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.250000m, 8.992500m, new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.192500m, 8.942920m, 37714800 },
                    { new Guid("23586712-3b72-46a4-bca8-ed616788cb4a"), 9.145000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.145000m, 8.935000m, new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.997500m, 8.753214m, 24673600 },
                    { new Guid("82052bfe-dab2-4e25-9827-4639cdb8aa73"), 9.287500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.322500m, 9.067500m, new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.125000m, 8.877253m, 35486800 },
                    { new Guid("7b2512a5-7546-4d4c-ae6a-3a2addd66511"), 8.412500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.745000m, 8.245000m, new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.445000m, 8.215714m, 66399200 },
                    { new Guid("4e216ca9-2a83-4108-89e5-00e9f55e6fa0"), 12.075000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.415000m, 12.000000m, new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.267500m, 11.957350m, 54632800 },
                    { new Guid("b3ff6be4-3928-410a-b9b4-7a70d42215b3"), 12.347500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.347500m, 11.807500m, new DateTime(2019, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.970000m, 11.667374m, 48477200 },
                    { new Guid("af3543d6-ae29-4687-803d-293bca920c30"), 9.000000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.707500m, 7.642500m, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.500000m, 8.291323m, 70036800 },
                    { new Guid("a2b75a67-aae0-47d0-a5c3-5b006d770945"), 11.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.692500m, 9.975000m, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.770000m, 10.505594m, 80331600 },
                    { new Guid("9dd8bafb-233d-4530-8e8f-10ed39fccb71"), 11.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.752500m, 10.570000m, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.747500m, 11.459097m, 82114000 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("62ea8ada-e047-49d5-9a73-86d38f50759d"), 9.755000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.590000m, 9.695000m, new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.090000m, 9.842289m, 97178400 },
                    { new Guid("dadbc371-f5b2-4b2e-96af-bdac0421bbd1"), 11.032500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.602500m, 10.762500m, new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.332500m, 11.054286m, 113371200 },
                    { new Guid("88cc4d79-f3cc-43e5-821c-d746aa24b548"), 13.000000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.000000m, 11.650000m, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.947500m, 11.654186m, 84786000 },
                    { new Guid("e40324b0-f4b3-43c4-9c68-032c558991fc"), 13.600000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.615000m, 12.967500m, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.112500m, 12.790586m, 45342400 },
                    { new Guid("4baa5ac0-8efe-4297-9a1b-da3b9a46a786"), 10.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.690000m, 8.552500m, new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.500000m, 10.242224m, 120562800 },
                    { new Guid("7c9e70a7-6751-436e-86c0-2bb91dc8e43a"), 13.170000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.700000m, 12.917500m, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.212500m, 12.888129m, 58392000 },
                    { new Guid("fa334b1c-665b-4716-8b95-7412ce880adc"), 12.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.630000m, 11.805000m, new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.630000m, 12.319931m, 78799200 },
                    { new Guid("955b3463-450a-4a53-b32c-fb06f0708358"), 13.000000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.350000m, 12.505000m, new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.562500m, 12.254089m, 58818800 },
                    { new Guid("3c49e596-f867-462a-9836-410f6a806f19"), 13.265000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.512500m, 12.940000m, new DateTime(2020, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.220000m, 12.895447m, 53716400 },
                    { new Guid("1afd9c7f-7d37-4992-a295-d3a205cfacbc"), 13.912500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.455000m, 13.850000m, new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.112500m, 13.766035m, 38342000 },
                    { new Guid("d54d058d-4c6b-4828-ac57-a51b8df4e85a"), 14.482500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.532500m, 13.957500m, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.135000m, 13.787984m, 44558000 },
                    { new Guid("9323a865-f395-4fdd-9c50-abef45c3646e"), 14.587500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.725000m, 14.402500m, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.465000m, 14.109880m, 36514000 },
                    { new Guid("05a6d156-f616-405e-804d-b9be310a6315"), 14.562500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.775000m, 14.375000m, new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.555000m, 14.197673m, 38234000 },
                    { new Guid("b1764f01-1671-4254-8c54-739816573d9f"), 12.675000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.360000m, 12.455000m, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.137500m, 12.814972m, 64611600 },
                    { new Guid("c7ed20eb-f475-4cd5-9561-621a8a781aae"), 14.500000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.980000m, 14.287500m, new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.712500m, 14.351304m, 73775200 },
                    { new Guid("8db9da0e-d825-4d0c-8d98-0c72722c3ae9"), 8.750000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.977500m, 8.517500m, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.517500m, 8.308393m, 92384800 },
                    { new Guid("edb8dbe4-b37d-4390-8545-7cfb5d686ac5"), 8.005000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.405000m, 6.617500m, new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.202500m, 7.025677m, 121748400 },
                    { new Guid("59a3ead8-d3b5-43c7-a183-a4b9266785a0"), 10.705000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.925000m, 10.315000m, new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.412500m, 10.156872m, 51879600 },
                    { new Guid("3cd4f26f-7376-4247-acd8-ca807369cb98"), 10.067500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.550000m, 9.860000m, new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.490000m, 10.232468m, 63285200 },
                    { new Guid("cee2077b-38e6-4e58-b2ce-e12d0de3cebb"), 10.360000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.650000m, 10.022500m, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.022500m, 9.776446m, 78595200 },
                    { new Guid("c0b04ca6-650f-4d72-9db3-511e26f046b3"), 9.600000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.845000m, 9.305000m, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.550000m, 9.315546m, 65006000 },
                    { new Guid("a794d5b1-ab9f-4335-9d76-4d036c401bb3"), 8.835000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.912500m, 8.332500m, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.885000m, 8.666871m, 65810400 },
                    { new Guid("b8803556-24ef-4a86-8c7a-5cccb2463fbd"), 9.555000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.675000m, 8.777500m, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.972500m, 8.752222m, 82290000 },
                    { new Guid("d49592bc-1e06-4856-a167-e3e8adcdc7b6"), 9.350000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.782500m, 9.017500m, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.370000m, 9.139965m, 73661200 },
                    { new Guid("02058765-00e6-486b-bce7-f1c7d9f74a81"), 9.030000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.420000m, 8.212500m, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.892500m, 8.674187m, 108219600 },
                    { new Guid("c4c68c75-a6fa-4681-bfe9-c93244fb0644"), 10.620000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.800000m, 9.702500m, new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.747500m, 9.508198m, 97161600 },
                    { new Guid("25821b49-135f-4458-9564-a6c736febd0f"), 9.672500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.185000m, 9.412500m, new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.750000m, 9.510635m, 68294000 },
                    { new Guid("461eaf48-b5d2-4c13-832e-94bf00a373b8"), 10.160000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 11.100000m, 10.065000m, new DateTime(2020, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.280000m, 10.027623m, 91541200 },
                    { new Guid("0fee4a16-622b-4002-b55a-34b53278f8a8"), 9.225000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.837500m, 9.180000m, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.000000m, 9.754498m, 125173600 },
                    { new Guid("d647f40f-99d0-47e1-88c9-5f5fe3aeb02d"), 8.430000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.447500m, 8.430000m, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.170000m, 8.944876m, 82749200 },
                    { new Guid("d4c02f1e-5c41-4f01-a303-58b8be2045f5"), 8.125000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.232500m, 7.390000m, new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.552500m, 7.367085m, 85826000 },
                    { new Guid("5e793b47-8c9a-4f7a-8aaf-47d751aa3be9"), 8.200000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.017500m, 7.662500m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.662500m, 7.474384m, 113467200 },
                    { new Guid("f59bfe5c-755c-4f04-8795-0306d3618fcd"), 6.875000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.842500m, 6.250000m, new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.637500m, 7.449998m, 112723200 },
                    { new Guid("ed78397d-603a-48ca-9c05-68be59bb9f6d"), 10.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.505000m, 9.950000m, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.400000m, 10.144677m, 75768800 },
                    { new Guid("7c283f56-057d-4528-a666-8bc16057ebdf"), 12.372500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.470000m, 12.165000m, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.325000m, 12.013398m, 42746000 },
                    { new Guid("9e21d95f-0dff-4807-bb4d-b89e0b17b834"), 14.400000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.490000m, 14.000000m, new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.082500m, 13.736772m, 36680000 },
                    { new Guid("53f1d07c-a8f4-41b8-853f-e5531227ebb4"), 13.632500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.137500m, 13.562500m, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.985000m, 13.641665m, 42104000 },
                    { new Guid("f3a0cc06-5ec7-4a59-a95c-6ff27945f60c"), 13.500000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.762500m, 13.400000m, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.500000m, 13.168572m, 33180800 },
                    { new Guid("b6ff6033-b39d-4c6a-970a-8157d62f2de3"), 13.050000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.557500m, 13.037500m, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.557500m, 13.224661m, 34307200 },
                    { new Guid("c7c85e91-89f2-4b15-a44c-9fb45ac9802b"), 13.022500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.262500m, 12.762500m, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.950000m, 12.632074m, 37484400 },
                    { new Guid("b3827c13-9b77-4753-81a4-d425a8041760"), 12.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.057500m, 12.605000m, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.020000m, 12.700356m, 44120000 },
                    { new Guid("42765a84-8126-4906-bec8-063418430ca0"), 12.155000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.587500m, 12.125000m, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.572500m, 12.263843m, 40007200 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("f21513dc-ea78-41c4-a4ae-0ee245f26540"), 12.235000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.300000m, 12.125000m, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.197500m, 11.898048m, 26818800 },
                    { new Guid("94689b9f-e819-4390-839b-3ee235c688cd"), 12.100000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.327500m, 11.950000m, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.232500m, 11.932190m, 27359200 },
                    { new Guid("673c4fc0-97ee-4e84-a706-50030156463a"), 13.420000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.590000m, 13.300000m, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.415000m, 13.085658m, 36965600 },
                    { new Guid("1c7a632d-9123-431f-b5c0-3279da1d1b77"), 12.125000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.332500m, 12.075000m, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.222500m, 11.922435m, 26737600 },
                    { new Guid("4ff821a7-8f8f-42bf-834a-8895361fafdd"), 12.200000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.247500m, 11.877500m, new DateTime(2019, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.925000m, 11.623511m, 32350400 },
                    { new Guid("c7e0ebb5-52f7-40b6-9f62-368d99fa0d60"), 12.287500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.352500m, 12.037500m, new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.182500m, 11.874501m, 23699600 },
                    { new Guid("5c766c43-3c4a-4da4-ac34-7e7a7767f4b0"), 12.200000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.275000m, 12.157500m, new DateTime(2019, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.272500m, 11.962226m, 19397200 },
                    { new Guid("88de2a99-e05d-4a10-95d1-77d1d627d39f"), 12.150000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.312500m, 12.100000m, new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.185000m, 11.876938m, 26009200 },
                    { new Guid("ff94f95a-9b44-49d5-9957-06ea05c67bf4"), 12.155000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.257500m, 11.990000m, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.147500m, 11.840387m, 36742800 },
                    { new Guid("c3aca240-5cb4-42ce-8ae0-8776736c4f79"), 12.132500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.182500m, 11.975000m, new DateTime(2019, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.155000m, 11.847696m, 30079600 },
                    { new Guid("a6d315c7-5865-433a-99b1-36dbaa14fb46"), 12.037500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.250000m, 11.915000m, new DateTime(2019, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.132500m, 11.825764m, 41210000 },
                    { new Guid("5313b950-ec8a-4db5-b6d7-ae6ad55b8e9b"), 12.075000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 12.332500m, 11.927500m, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.332500m, 12.029735m, 29600800 },
                    { new Guid("11fe48e6-67d5-4f61-a3c5-69034c7952ac"), 13.730000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.325000m, 13.525000m, new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.262500m, 13.912353m, 54978400 },
                    { new Guid("89e88f6a-50ef-4886-b403-cc1f35eb3a31"), 13.550000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.680000m, 13.075000m, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.365000m, 13.036887m, 33515200 },
                    { new Guid("d1acdaf9-9b9d-4d94-9b54-6e38bd3ce726"), 13.530000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.000000m, 13.512500m, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.000000m, 13.656297m, 29623600 },
                    { new Guid("bfaa358d-25c0-4c7e-8060-5e6fa9e2ee2b"), 13.300000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.700000m, 12.932500m, new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.567500m, 13.234415m, 37954800 },
                    { new Guid("46dbf9d1-52ce-411f-abc3-46f1d0188267"), 13.500000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.882500m, 12.885000m, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.095000m, 12.773516m, 51324800 },
                    { new Guid("3f52133f-afb0-4ece-b3e3-cc0ee00e1a31"), 13.925000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.982500m, 13.375000m, new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.557500m, 13.224661m, 39083200 },
                    { new Guid("4d1d6c13-10f7-40c3-9e96-e20f7bf706b3"), 14.500000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.537500m, 13.950000m, new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.957500m, 13.614841m, 41164000 },
                    { new Guid("947845dc-bef8-472c-97b4-7eb4761212a1"), 14.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.710000m, 14.257500m, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.325000m, 13.973318m, 34484400 },
                    { new Guid("8c1c0ed4-13ae-4991-8499-d0b5f5a4b944"), 14.400000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.667500m, 14.282500m, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.415000m, 14.061110m, 32872800 },
                    { new Guid("bdcca0fd-6afe-4687-8b75-5b3b3e655d76"), 14.120000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.237500m, 13.915000m, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.132500m, 13.785544m, 24566000 },
                    { new Guid("9f9a7567-985f-4de1-84bf-03192c833a90"), 13.450000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.607500m, 13.275000m, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.587500m, 13.253923m, 24184000 },
                    { new Guid("7b89bbe7-22e4-496d-b31d-88cb51c373ca"), 13.910000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.287500m, 13.800000m, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.950000m, 13.607524m, 38781200 },
                    { new Guid("7857a96a-4b8b-4bff-9a16-0774020452e8"), 14.377500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.522500m, 14.162500m, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.322500m, 13.970881m, 39798000 },
                    { new Guid("2241bcc4-2551-4459-b924-c04d62191f24"), 13.502500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.247500m, 13.502500m, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.247500m, 13.897720m, 41425600 },
                    { new Guid("975a0e9f-569c-4467-8390-ef371bccd7c2"), 13.762500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 13.825000m, 13.437500m, new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.450000m, 13.119799m, 30095200 },
                    { new Guid("fdb30f6c-dd40-4f9b-b788-7f77a00dbd05"), 14.192500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.262500m, 14.000000m, new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.037500m, 13.692876m, 30074800 },
                    { new Guid("8c9e3bf9-8e10-446a-b0e4-b7539ae44330"), 13.920000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.180000m, 13.732500m, new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.145000m, 13.797739m, 32739600 },
                    { new Guid("53e12b34-91b3-4bad-befe-f7e562793a56"), 14.127500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.275000m, 13.707500m, new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.922500m, 13.580700m, 36062400 },
                    { new Guid("6139c251-50c4-4a5c-9730-a0c48c334de9"), 13.930000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.185000m, 13.902500m, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.977500m, 13.634349m, 32257200 },
                    { new Guid("438dce13-0a3a-4595-b70b-a058e46f45a5"), 14.092500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 14.175000m, 13.755000m, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.125000m, 13.778227m, 44303600 },
                    { new Guid("419c7364-a0eb-437f-bc71-582eb20b8f5e"), 10.272500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.525000m, 10.167500m, new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.477500m, 10.220276m, 33824400 },
                    { new Guid("05fe46dd-2832-445c-9c32-67fce1efd04e"), 9.175000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.225000m, 8.570000m, new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.607500m, 8.373804m, 52826400 },
                    { new Guid("581d5d47-ec06-4c85-9871-9b3daa6cd374"), 9.412500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.420000m, 9.052500m, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.132500m, 8.884548m, 41342400 },
                    { new Guid("1230c775-8813-4351-a4e8-51c741f0e592"), 5.465625m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.518437m, 5.430625m, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.518437m, 5.356452m, 24489600 },
                    { new Guid("fd0cc7d0-9b30-4e6e-abf3-99a08b5df92c"), 5.429687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.512500m, 5.330312m, new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.409687m, 5.250894m, 33091200 },
                    { new Guid("47000585-7efa-415e-8c7e-8b3d6863e093"), 5.621875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.684062m, 5.397500m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.415625m, 5.256658m, 44316800 },
                    { new Guid("326ca340-bb44-4640-b4cf-42663b8ae378"), 5.642187m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.695312m, 5.593750m, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.695312m, 5.528135m, 31497600 },
                    { new Guid("025300e8-f004-4504-af5c-c66bb6203da9"), 5.647187m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.696875m, 5.598750m, new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.675937m, 5.509328m, 23216000 },
                    { new Guid("7baa5546-11a0-4bf4-9ff6-bfb71e0d0c05"), 5.617187m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.712187m, 5.603437m, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.646875m, 5.481119m, 21654400 },
                    { new Guid("f2f3bb9a-5b01-49ad-8015-9abbb5f38548"), 5.531250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.670625m, 5.504687m, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.638125m, 5.472626m, 43244800 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("95d0d675-f639-40df-8b23-ae90f54730b0"), 5.468750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.468750m, 5.198750m, new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.250000m, 5.095894m, 51513600 },
                    { new Guid("fbbe878f-711f-4363-8de5-8c9c0f266a67"), 5.562500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.578125m, 5.484687m, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.537187m, 5.374651m, 25369600 },
                    { new Guid("0f096d76-1a71-4e4d-a0b3-3316eccc286e"), 5.570312m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.611562m, 5.487500m, new DateTime(2019, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.540000m, 5.377381m, 22969600 },
                    { new Guid("53f9dca8-a44f-4173-a63a-96e8142b0caa"), 5.656250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.672187m, 5.560625m, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.589062m, 5.425004m, 22624000 },
                    { new Guid("d361696e-5af5-4f5a-9162-0d971ac993e4"), 5.648437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.745000m, 5.570312m, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.705312m, 5.537841m, 39078400 },
                    { new Guid("93118841-14a2-4498-96be-5f550d91182f"), 5.496875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.730625m, 5.431250m, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.650625m, 5.484759m, 54208000 },
                    { new Guid("09c576d0-345f-44ae-b5d4-19051353e3d7"), 5.359062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.562187m, 5.328125m, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.535937m, 5.373438m, 39683200 },
                    { new Guid("3f622875-745f-4bd0-b0a6-56c82e795a98"), 5.473437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.479687m, 5.348125m, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.362812m, 5.205395m, 15523200 },
                    { new Guid("967ff86e-2b62-49b4-aca5-ffa4245df97a"), 5.465312m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.593750m, 5.412812m, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.475625m, 5.314896m, 28412800 },
                    { new Guid("1a7c25ce-b3bc-4f14-b4f2-1a1154392c45"), 5.529687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.580312m, 5.486562m, new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.515625m, 5.353722m, 13638400 },
                    { new Guid("da2412de-1b03-46d7-974e-7e501f58337b"), 5.496875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.530625m, 5.314687m, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.420625m, 5.261511m, 32044800 },
                    { new Guid("3ee637c0-44f0-497e-9193-b3028992360e"), 5.281562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.388750m, 5.161562m, new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.337187m, 5.180521m, 44809600 },
                    { new Guid("a3c51ee0-4935-416c-aef3-9241c8c849f2"), 5.436562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.460625m, 5.352812m, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.352812m, 5.195687m, 16227200 },
                    { new Guid("24c4222f-060a-4182-8268-d4268bfe7cb7"), 5.333437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.405625m, 5.265625m, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.389375m, 5.243051m, 26000000 },
                    { new Guid("5accd8f1-3eaf-4008-8ffd-b5e26b521a7a"), 5.250312m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.357500m, 5.250000m, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.343750m, 5.198665m, 16678400 },
                    { new Guid("5fa4e728-71eb-4431-a323-b6380afd78e7"), 5.309687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.316875m, 5.190937m, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.225000m, 5.083139m, 13920000 },
                    { new Guid("afe493f4-2ed4-4a8f-9c7f-61a8f5251f80"), 5.024375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.352187m, 5.010937m, new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.337500m, 5.192585m, 44016000 },
                    { new Guid("51993a67-3ce8-486e-bfb8-4b4064da1b85"), 5.111250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.148125m, 4.953750m, new DateTime(2019, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.994375m, 4.858776m, 39385600 },
                    { new Guid("af5d8783-cc60-4651-93cb-3911ee5577a7"), 5.100000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.179062m, 5.050000m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.084375m, 4.946332m, 23929600 },
                    { new Guid("a70c6d4c-6270-40f4-905a-bf644b1c0bbb"), 5.187500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.215000m, 5.075000m, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.109375m, 4.959397m, 41980800 },
                    { new Guid("9353105a-590d-4ef5-a41d-b84cb0b625cb"), 5.381250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.435937m, 5.343750m, new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.401562m, 5.243007m, 22960000 },
                    { new Guid("66a19ca5-50af-4ea8-8806-c26e83ed6663"), 5.127500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.270625m, 5.071875m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.150937m, 4.999739m, 26668800 },
                    { new Guid("7e112691-7cd4-45f8-a501-a4d294ae17a6"), 5.218750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.271875m, 5.172500m, new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.271875m, 5.117127m, 20364800 },
                    { new Guid("76d6478c-6573-4955-b0e4-d74a0ae3ac35"), 5.192187m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.261250m, 5.109375m, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.197187m, 5.044631m, 33910400 },
                    { new Guid("c0e5839d-e6a2-4c4b-9e79-3f1b4b2f56ae"), 5.303125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.318750m, 5.159687m, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.210625m, 5.057674m, 77120000 },
                    { new Guid("631a8855-e3db-4b91-9f4a-6feaf8d4c352"), 5.285000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.335000m, 5.236250m, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.312187m, 5.156256m, 23593600 },
                    { new Guid("01074533-b75c-4dc6-beb8-d4a01ac104d2"), 5.312500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.354687m, 5.235312m, new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.281250m, 5.126227m, 22780800 },
                    { new Guid("dcc2f506-13ce-4148-874c-dc004f32c47b"), 5.248437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.398750m, 5.212812m, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.283437m, 5.128349m, 40563200 },
                    { new Guid("cbe35c4c-d6eb-4ee1-8ef3-9a5c3861698a"), 5.389687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.389687m, 5.171875m, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.192187m, 5.039778m, 35606400 },
                    { new Guid("66110d4e-89ed-44d5-906c-adb5fad4312b"), 5.262500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.262500m, 5.125000m, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.187500m, 5.035228m, 20828800 },
                    { new Guid("8ac766fa-ad60-48e2-9dc5-4235786b59f8"), 5.344375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.468750m, 5.314375m, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.468750m, 5.320271m, 24780800 },
                    { new Guid("6452b2ea-0c95-4deb-9f29-60e54184a8e5"), 5.578125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.611875m, 5.462812m, new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.500000m, 5.338556m, 25504000 },
                    { new Guid("a33488cc-befc-4301-aba0-a787b96eddcd"), 5.586250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.621875m, 5.428125m, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.428125m, 5.268791m, 41360000 },
                    { new Guid("a27b826c-20b9-44f5-b388-be434b8d4431"), 5.328750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.353125m, 5.160937m, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.233750m, 5.080121m, 36246400 },
                    { new Guid("eccef15a-bd26-4af6-8ffa-1bda5239cdda"), 5.124687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.317500m, 5.087812m, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.300000m, 5.144426m, 38249600 },
                    { new Guid("3270b9e4-aa01-4fe5-a8f6-fffb26a0a217"), 5.098437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.217187m, 5.020312m, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.064062m, 4.915414m, 65046400 },
                    { new Guid("d2d8ddef-8752-4dfe-aa69-f65af5e9199b"), 5.437187m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.444375m, 5.218750m, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.218750m, 5.065561m, 40012800 },
                    { new Guid("829b7722-2cde-45b5-9da1-c552da05d33d"), 5.484375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.526562m, 5.421875m, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.443750m, 5.283957m, 22496000 },
                    { new Guid("15d3fd5e-6a95-4375-839d-27d5fbcd244a"), 5.439062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.506875m, 5.398437m, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.452500m, 5.292450m, 28726400 },
                    { new Guid("6d5dbe4e-e579-477d-b5dc-1ed985483bbe"), 5.534375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.562500m, 5.411875m, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.468750m, 5.308223m, 35452800 },
                    { new Guid("8a4bcc15-c1aa-4d9c-bb70-a7a90629e08e"), 5.187187m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.265625m, 5.125312m, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.230625m, 5.077088m, 25052800 },
                    { new Guid("dd3c38a8-d0ff-4069-b478-3705b51fd104"), 5.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.653125m, 5.486875m, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.530312m, 5.367978m, 32902400 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("bd3ec251-2be9-44dd-a8c2-ed55e770f0f0"), 5.656250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.673125m, 5.547187m, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.550000m, 5.387088m, 37481600 },
                    { new Guid("b634c83e-7c07-41a3-bbed-51e5f916e0cf"), 5.594062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.659375m, 5.556250m, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.651562m, 5.485669m, 24432000 },
                    { new Guid("5385c63d-0252-457f-aa81-f558684a6f53"), 5.656250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.687500m, 5.554687m, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.597187m, 5.432890m, 24796800 },
                    { new Guid("4f3530b0-5ee5-4d1f-b523-0287cd8e4dab"), 5.673437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.702812m, 5.593750m, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.615937m, 5.451090m, 19398400 },
                    { new Guid("c5652864-39fc-408a-86d4-c0685058631d"), 5.562500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.702500m, 5.539687m, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.661562m, 5.495375m, 21174400 },
                    { new Guid("2fe99b85-17e9-43c6-8c95-9cbcdf845fd2"), 5.751562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.760937m, 5.573437m, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.575000m, 5.411354m, 27721600 },
                    { new Guid("8f5639a3-105f-4749-8f0b-51341e33c080"), 5.780937m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.796562m, 5.605000m, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.750000m, 5.581217m, 26342400 },
                    { new Guid("8c176e57-978d-4f43-a858-1ee4f66e56fd"), 5.559687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.615312m, 5.500000m, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.593750m, 5.429554m, 34128000 },
                    { new Guid("d914af92-ec06-4469-9588-50650b6645ab"), 5.406562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.620937m, 5.350000m, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.578125m, 5.414387m, 33779200 },
                    { new Guid("68922362-baa1-48ef-bb1a-432797377e17"), 5.253125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.615625m, 5.250312m, new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.565625m, 5.402255m, 51174400 },
                    { new Guid("445ce6cd-8e55-4b05-b138-7dc1287ef31f"), 5.546875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.655625m, 5.427500m, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.595937m, 5.431677m, 30585600 },
                    { new Guid("ab5d317b-168f-4d51-bb1e-f5f2ae279ea1"), 5.312812m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.661250m, 5.185312m, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.559375m, 5.396187m, 122038400 },
                    { new Guid("b3129371-a4dd-497e-95b7-ac8dff4d9747"), 5.129062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.140625m, 4.986562m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.034375m, 4.886599m, 40636800 },
                    { new Guid("494b93ca-dd28-429e-aad2-bf498e97dbfb"), 5.371250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.371250m, 5.070312m, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.078125m, 4.929065m, 48358400 },
                    { new Guid("5f401487-6542-4c55-b326-794521ad9e25"), 5.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.374375m, 5.237812m, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.301875m, 5.146246m, 30272000 },
                    { new Guid("0780a3b7-5ace-4f3c-ac19-349e6593eeef"), 5.121250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.266875m, 5.078125m, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.266875m, 5.112274m, 14982400 },
                    { new Guid("4b12d74f-b57a-4e64-b5fd-37c8a33e8393"), 5.296875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.312187m, 5.124062m, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.124062m, 4.973652m, 31440000 },
                    { new Guid("969e2d5d-ecd4-4936-9079-33219b49da29"), 5.078125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.343437m, 5.000625m, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.334062m, 5.177489m, 33744000 },
                    { new Guid("a3bf097a-cca7-4f2f-b1cc-16cfe77bc59d"), 5.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.687500m, 5.410312m, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.504687m, 5.343105m, 43971200 },
                    { new Guid("f4ae75b9-dbfc-46a1-88b5-d4b51cbf8ce1"), 5.174062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.187500m, 4.944062m, new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.040625m, 4.892664m, 38464000 },
                    { new Guid("668f26e9-baf8-4d25-bbad-f9ab4926812c"), 5.311250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.311875m, 5.140937m, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.166562m, 5.014905m, 21715200 },
                    { new Guid("56628872-a676-4d8a-a32c-5faa62cef099"), 5.250000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.312500m, 5.142500m, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.312500m, 5.156559m, 22025600 },
                    { new Guid("12328726-dcf8-46b7-b598-b6186e6963ad"), 5.331562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.481250m, 5.212500m, new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.212500m, 5.059494m, 37664000 },
                    { new Guid("241c0862-87e4-4637-811f-1b573d4fab20"), 5.452500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.453125m, 5.265625m, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.303125m, 5.147460m, 25846400 },
                    { new Guid("c31a4dda-30b5-4f90-ae8a-1f758bca0955"), 5.527812m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.542500m, 5.462500m, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.484375m, 5.323390m, 14454400 },
                    { new Guid("02fdefea-b81b-40d6-af27-d9b3a8b2e175"), 5.546875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.567187m, 5.453437m, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.533437m, 5.371011m, 17363200 },
                    { new Guid("a318b55f-0df7-493d-8661-443b6fe81340"), 5.593750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.640000m, 5.503750m, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.587500m, 5.423487m, 20665600 },
                    { new Guid("14499655-e727-4fc6-ba7a-cbd10a921e33"), 5.219062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.255937m, 5.103125m, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.150000m, 4.998830m, 32627200 },
                    { new Guid("d28e3945-c170-40b8-ac7d-24d9f5335c22"), 9.192500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.305000m, 9.135000m, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.135000m, 8.886981m, 25524400 },
                    { new Guid("32c38fa6-f4ef-4199-a98a-8b0c3c5e7cd7"), 5.500000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.623437m, 5.479375m, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.592187m, 5.440356m, 37011200 },
                    { new Guid("624af23e-cec6-445b-9d62-36b786240924"), 5.737500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.976875m, 5.718750m, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.976875m, 5.814600m, 68633600 },
                    { new Guid("b271cf51-436c-4ab9-a93c-174b410d1d2c"), 7.531250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.733437m, 7.468750m, new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.729687m, 7.519824m, 47913600 },
                    { new Guid("053b0ee0-4102-4365-b662-f6aa48849997"), 7.781250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.793750m, 7.439062m, new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.439062m, 7.237089m, 48448000 },
                    { new Guid("ab91a39d-695d-4883-8ae0-bf11a5f76776"), 7.734687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.826562m, 7.659687m, new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.718750m, 7.509182m, 39859200 },
                    { new Guid("2042168e-2ffc-46dd-af57-1776002a014d"), 7.409375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.841875m, 7.409375m, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.637187m, 7.429834m, 83689600 },
                    { new Guid("fc8c09db-86ed-4016-93d3-7a0bf2c69f68"), 7.245312m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.318437m, 7.232812m, new DateTime(2019, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.312500m, 7.113962m, 22313600 },
                    { new Guid("36b7f1ac-2208-4d7e-ba7e-cc1da4667537"), 7.343750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.355937m, 7.188437m, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.207812m, 7.012116m, 29961600 },
                    { new Guid("0b9161ff-ca65-4b47-a6c9-93ce73fc3ef0"), 7.343750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.511250m, 7.250000m, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.251562m, 7.054679m, 61776000 },
                    { new Guid("051ebb77-4dc7-4392-a0e7-2b58da95ab14"), 7.781875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.799375m, 7.542187m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.562500m, 7.357175m, 36387200 },
                    { new Guid("8308d20c-204a-41b7-81b2-6dba40423bef"), 7.368750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.368750m, 7.160937m, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.211562m, 7.015765m, 34518400 },
                    { new Guid("3fe7b6bd-5589-4240-b220-2b67c9b8ad57"), 7.065312m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.225000m, 7.037500m, new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.168750m, 6.974115m, 30169600 },
                    { new Guid("ac0df042-a6ba-49cb-b8c5-b17668e8a598"), 6.937500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.130312m, 6.889375m, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.065000m, 6.873182m, 31500800 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("8a2c4934-0ed7-48c3-ac23-024ca9931e0f"), 6.956875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.000000m, 6.909375m, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.909375m, 6.721782m, 36316800 },
                    { new Guid("b9551a25-5640-4f27-bb55-63a625f6ee55"), 6.619687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.902187m, 6.601250m, new DateTime(2019, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.901562m, 6.714182m, 43267200 },
                    { new Guid("dc915991-0f56-4352-80ee-d8610f4b8601"), 6.585937m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.640625m, 6.531250m, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.639375m, 6.459113m, 22755200 },
                    { new Guid("30b7f6a2-34ac-4290-92ea-4db750ef098c"), 6.625000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.675000m, 6.536562m, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.568750m, 6.390405m, 22857600 },
                    { new Guid("6d49dfa2-4e3a-49e8-969c-86584c3a2318"), 6.543750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.597500m, 6.480937m, new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.597500m, 6.418375m, 32460800 },
                    { new Guid("bc7cf55f-229f-4f12-939f-38f92aab3b25"), 7.226562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.371562m, 7.226562m, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.296875m, 7.098762m, 35814400 },
                    { new Guid("db64d1cd-4b68-4ffa-8542-9573b18a1305"), 6.509062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.546562m, 6.420937m, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.520312m, 6.343283m, 23817600 },
                    { new Guid("a5c3c456-fda2-4a15-9aae-56729b48a21a"), 7.593750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.784375m, 7.593750m, new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.681562m, 7.473004m, 27779200 },
                    { new Guid("8ffd56b8-4ea2-402a-b6bd-34ea077cb0f4"), 7.694375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.931250m, 7.653125m, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.875000m, 7.661191m, 37884800 },
                    { new Guid("beb1280d-53d7-487a-870b-e6a52d2b8c2c"), 9.517500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.550000m, 9.325000m, new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.457500m, 9.200726m, 23158000 },
                    { new Guid("c553a4ca-1710-46ff-8bff-e5e92fe368f0"), 9.397500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.462500m, 9.100000m, new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.390000m, 9.135057m, 35834400 },
                    { new Guid("de7a86b9-6eec-4aac-ac67-a5ee4402a78f"), 9.375000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.507500m, 9.027500m, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.077500m, 8.831042m, 40306800 },
                    { new Guid("3b04e4ae-3978-4416-950b-16d4d840c9df"), 9.342500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.562500m, 9.145000m, new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.237500m, 8.986698m, 52995600 },
                    { new Guid("9e2bc395-498a-4229-a15a-da3500ed9e6a"), 9.400000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.575000m, 9.355000m, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.462500m, 9.205588m, 64444400 },
                    { new Guid("575374ef-6ccb-4e03-bf0e-5e6a14cc91e6"), 9.442500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.442500m, 8.992500m, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.105000m, 8.857795m, 38738800 },
                    { new Guid("cf7a8c11-7b75-4975-97bf-e237368942e3"), 9.287500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.665000m, 9.285000m, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.445000m, 9.188563m, 48288400 },
                    { new Guid("10beadb1-5112-4f43-a02b-3ced45600635"), 7.740625m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 7.758125m, 7.566562m, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.640000m, 7.432570m, 35929600 },
                    { new Guid("c8b35eda-00c5-46cd-a489-67342eee0142"), 9.175000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.335000m, 9.137500m, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.285000m, 9.032908m, 39026400 },
                    { new Guid("5396a42c-b4a8-48bf-b87a-43cb1ab21b78"), 8.897500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.265000m, 8.882500m, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.150000m, 8.901573m, 69824400 },
                    { new Guid("39c95cb4-676c-4372-8809-92c8386a09e5"), 8.812500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.812500m, 8.603437m, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.625000m, 8.390828m, 59516800 },
                    { new Guid("5ecdc79b-6a6c-4da1-bde1-66f69edeb77a"), 8.768750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.899687m, 8.671875m, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.860937m, 8.620358m, 45667200 },
                    { new Guid("5435c18e-3d78-405f-bd6a-5e752d3b4f43"), 8.421875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.726250m, 8.384375m, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.640625m, 8.406029m, 79395200 },
                    { new Guid("3468ee50-2d57-4a29-95d7-785cbde5c150"), 8.371875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.437500m, 8.135625m, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.241250m, 8.017494m, 50419200 },
                    { new Guid("626703a3-42a8-480f-aa3e-28651390a6b6"), 8.243750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.482500m, 8.219375m, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.267187m, 8.042729m, 56502400 },
                    { new Guid("a0fdfe69-9380-4e68-8da1-b3165d09abd4"), 7.875000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 8.263750m, 7.832812m, new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.243750m, 8.019929m, 46249600 },
                    { new Guid("dc473a68-aebf-48fd-b965-5ff87f7ef5dd"), 9.225000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 9.225000m, 8.810000m, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.077500m, 8.831042m, 46431600 },
                    { new Guid("3f027755-724f-4856-988b-a63d388f8875"), 5.593750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.625000m, 5.540000m, new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.578437m, 5.426980m, 16448000 },
                    { new Guid("48055ab1-34b8-42f5-983c-c55b40a0291d"), 6.500000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.564375m, 6.468750m, new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.514062m, 6.337202m, 22841600 },
                    { new Guid("4bfd1bcf-166b-4b81-b5f8-46b7e2dfb71a"), 6.630000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.684375m, 6.519375m, new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.561875m, 6.383717m, 27094400 },
                    { new Guid("1919d68f-c145-439d-b3b7-5110eb52aaa4"), 5.553125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.696562m, 5.472500m, new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.639062m, 5.485959m, 33337600 },
                    { new Guid("cae6103d-30a1-46e1-9876-adb6ff7af7d6"), 5.656250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.755937m, 5.562500m, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.632812m, 5.479878m, 35641600 },
                    { new Guid("9b99ecea-4f87-4151-af63-71558337b022"), 5.496250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.677812m, 5.487812m, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.606562m, 5.454341m, 37299200 },
                    { new Guid("05ddcadd-58e3-4642-93b3-578a62d50216"), 5.311875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.475000m, 5.287812m, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.406250m, 5.259468m, 32944000 },
                    { new Guid("4c103908-535a-4a0f-9d52-d4d5fe74e644"), 5.158437m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.400625m, 5.158437m, new DateTime(2019, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.275625m, 5.132390m, 33945600 },
                    { new Guid("5f7cc8f7-b39b-496d-b4ab-0257905bd3b6"), 5.381250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.400625m, 5.211562m, new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.218750m, 5.077058m, 56912000 },
                    { new Guid("a982f14a-216f-4734-8291-184bf2880572"), 5.507500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.507500m, 5.365625m, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.406250m, 5.259468m, 47628800 },
                    { new Guid("101b8e3e-4ba4-4560-aa9c-d9cccc20307e"), 5.702812m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.735000m, 5.500000m, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.526562m, 5.376514m, 25910400 },
                    { new Guid("65657edd-d7e0-4d86-8429-e7b2fe883af7"), 5.719062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.781250m, 5.562500m, new DateTime(2019, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.570312m, 5.419076m, 32684800 },
                    { new Guid("3c956cb2-7fa3-49ac-ac0b-ec75d4fb6767"), 5.844687m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.897500m, 5.658125m, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.828125m, 5.669889m, 28297600 },
                    { new Guid("1fd1f665-8913-433d-8934-7c8a48c2ed80"), 6.026875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.026875m, 5.809375m, new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.809375m, 5.651648m, 34588800 },
                    { new Guid("dc6231b6-137c-4a89-906b-950754edd093"), 6.003125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.109375m, 6.003125m, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.046875m, 5.882699m, 29065600 },
                    { new Guid("2c6a11fb-adb3-4892-b77d-07fe0d23c91f"), 6.296875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.322187m, 5.977500m, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.004687m, 5.841657m, 54857600 }
                });

            migrationBuilder.InsertData(
                table: "Cotacoes",
                columns: new[] { "IdCotacao", "Abertura", "AcaoId", "Alta", "Baixa", "Data", "Fechamento", "FechamentoAjustado", "Volume" },
                values: new object[,]
                {
                    { new Guid("8407814a-2aa1-470d-a35f-e4ee4c24132d"), 6.093750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.280000m, 6.063437m, new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.256562m, 6.086694m, 49232000 },
                    { new Guid("7e9caef0-f21c-4e58-9f36-1ac18e8a0acb"), 5.968750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.218750m, 5.968750m, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.132812m, 5.966303m, 38476800 },
                    { new Guid("127d2817-b2f6-48a8-b5ff-08b6aa184d83"), 5.899062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.017187m, 5.871875m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.960625m, 5.798791m, 43356800 },
                    { new Guid("9a33c53d-64be-4bb5-888c-7a804a710033"), 5.765625m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.789062m, 5.625000m, new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.625625m, 5.472887m, 29926400 },
                    { new Guid("850659b6-742c-4b0d-8316-e88b4f088d48"), 6.531250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.593437m, 6.453125m, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.453437m, 6.278223m, 33401600 },
                    { new Guid("deb23989-fd0b-466b-afec-cc37124d266e"), 5.656250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.687500m, 5.562500m, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.562500m, 5.411476m, 15702400 },
                    { new Guid("794343f1-7948-4b0b-aa82-7b518afccf3c"), 5.946875m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.106250m, 5.847187m, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.914687m, 5.754100m, 45321600 },
                    { new Guid("17c84422-0cca-495b-9721-a82ccba644f7"), 6.593750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.686875m, 6.589687m, new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.645312m, 6.464888m, 39737600 },
                    { new Guid("0c7fd2e6-fca6-4e79-8a4d-9ae005418c4c"), 6.468750m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.593750m, 6.409062m, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.562500m, 6.384326m, 83241600 },
                    { new Guid("2395bb3b-b2b8-492b-9983-7c4262441ec1"), 6.581250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.643437m, 6.469687m, new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.503125m, 6.326562m, 35424000 },
                    { new Guid("3b3c13ca-1609-4f56-b5af-80ba195b4de8"), 6.628125m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.749687m, 6.463125m, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.484375m, 6.308321m, 44108800 },
                    { new Guid("0a3d8b5e-639a-4b05-9e85-329cc392bf3d"), 6.530937m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.718750m, 6.418750m, new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.611562m, 6.432055m, 47436800 },
                    { new Guid("c9a7442c-31da-476d-bd34-ba0fbf4e4ca9"), 6.437500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.569687m, 6.421562m, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.550312m, 6.372468m, 41241600 },
                    { new Guid("a4eefa66-8375-46e2-8619-07bd58b8c9f6"), 6.437500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.441875m, 6.281250m, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.347500m, 6.175162m, 42611200 },
                    { new Guid("d4993d4e-90b7-4c0b-bc5c-dbb479c3655d"), 5.634375m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 5.906250m, 5.629062m, new DateTime(2019, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.906250m, 5.745892m, 66128000 },
                    { new Guid("53b90c1c-afc8-4999-a244-253dc28df2ab"), 6.375000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.546875m, 6.364062m, new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.474687m, 6.298896m, 36195200 },
                    { new Guid("6d3f6dfc-8f57-43fb-8a23-01917eb50c33"), 5.961562m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.201562m, 5.954062m, new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.201562m, 6.033187m, 31520000 },
                    { new Guid("f6fddd85-bda6-43a0-bd7e-4668fe27c7cc"), 6.062500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.062500m, 5.878125m, new DateTime(2019, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.937812m, 5.776597m, 22060800 },
                    { new Guid("22b68fd6-ef92-4019-b1cd-6a03345c770c"), 6.125000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.162500m, 5.875937m, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.974687m, 5.812472m, 40675200 },
                    { new Guid("4b2507ba-6ee9-4257-b2f8-dba957fcb876"), 6.187500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.218437m, 6.000000m, new DateTime(2019, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.078750m, 5.913710m, 26220800 },
                    { new Guid("8c1939de-efb0-400f-883f-3e178af6e834"), 6.156250m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.212500m, 6.047187m, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.085625m, 5.920397m, 26694400 },
                    { new Guid("19113ca8-4725-492d-bdfb-6ee757df4076"), 6.000000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.125000m, 5.989062m, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.125000m, 5.958704m, 27113600 },
                    { new Guid("5a344dd5-f972-433f-84e7-e9da48d6d752"), 5.937500m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.075000m, 5.925625m, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.027812m, 5.864154m, 28982400 },
                    { new Guid("c8d88e8a-95c4-4f8d-b595-098e2a7004a4"), 6.204062m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 6.387500m, 6.140625m, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.328125m, 6.156314m, 37593600 },
                    { new Guid("bd3375c9-02cd-488c-bcea-485c70f8b72f"), 10.725000m, new Guid("77be8611-a9cb-4117-bba4-4763cd1a5635"), 10.850000m, 10.585000m, new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.725000m, 10.644061m, 45244400 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotacoes_AcaoId",
                table: "Cotacoes",
                column: "AcaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotacoes");

            migrationBuilder.DropTable(
                name: "Acoes");
        }
    }
}
