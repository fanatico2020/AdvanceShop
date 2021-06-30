DROP PROCEDURE IF EXISTS RelatorioRelacaoContasPorStatus;
DELIMITER 
CREATE PROCEDURE RelatorioRelacaoContasPorStatus(in StatusPagamento integer,in DataInicial DATETIME,in DataFinal DATETIME)
BEGIN

select c.idcontasapagar,c.status,c.referentea,ct.descricaocategoria,f.nome,c.valor,c.datavencimento,c.valorpago,c.datarecebimento from contasapagar c 
inner join categoriascontasapagar ct on ct.idcategoriascontasapagar = c.categoriascontasapagar_idcategoriascontasapagar 
inner join clientespessoas f on f.idclientespessoas = c.clientespessoas_idclientespessoas
where
(case
when StatusPagamento = 0 then c.deletado = 0 and c.status = 0 and c.datavencimento between 
cast(DataInicial as datetime) and cast(DataFinal as datetime)

when StatusPagamento = 1 then c.deletado = 0 and c.status = 1 and c.datarecebimento between 
cast(DataInicial as datetime) and cast(DataFinal as datetime)
else null
end);

END;
DELIMITER;


call RelatorioRelacaoContasPorStatus(0,'2021/06/01 00:00:00','2021/06/27 23:59:59');
