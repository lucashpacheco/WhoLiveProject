Use DbWhoLives

select * from dbo.Apartaments

select * from dbo.Residents

select * from dbo.Vehicles

select * from dbo.Staffs

INSERT INTO dbo.Residents (MOR_NOME, MOR_SOBRENOME , MOR_AP_ID , MOR_FUN_ID) VALUES ('Clara','Okio',2
,1) 

select MOR_ID ,MOR_NOME, MOR_SOBRENOME , AP_NUMERO , FUN_NOME from dbo.Residents
INNER JOIN DBO.Apartaments ON AP_ID = MOR_AP_ID
INNER JOIN DBO.Staffs ON MOR_FUN_ID = FUN_ID

select MOR_ID ,MOR_NOME AS [Nome], MOR_SOBRENOME AS [Sobrenome], AP_NUMERO , FUN_NOME from dbo.Residents
INNER JOIN DBO.Apartaments ON AP_ID = MOR_AP_ID
INNER JOIN DBO.Staffs ON MOR_FUN_ID = FUN_ID
ORDER BY MOR_AP_ID

SELECT * FROM dbo.Apartaments WHERE AP_ATENCAO = 1

SELECT COUNT(AP_NUMERO)  FROM dbo.Apartaments GROUP BY AP_ID

SELECT AP_NUMERO As Apartamento, CASE WHEN MOR_AP_ID < 1 THEN '0' ELSE COUNT(AP_ID) END AS Moradores FROM dbo.Residents

INNER JOIN dbo.Apartaments ON MOR_AP_ID = AP_ID

GROUP BY AP_NUMERO , MOR_AP_ID

SELECT AP_NUMERO As Apartamento,COUNT(VEI_ID) AS Veiculos FROM dbo.Apartaments

INNER JOIN dbo.Vehicles ON VEI_AP_ID = AP_ID

GROUP BY AP_NUMERO

SELECT AP_ID , AP_NUMERO as [Apartamento] , CASE WHEN AP_ATENCAO = 1 THEN 'SIM' WHEN AP_ATENCAO = 0 THEN 'NÃO' END AS [Atenção especial ?]FROM dbo.Apartaments WHERE AP_ATENCAO = 1