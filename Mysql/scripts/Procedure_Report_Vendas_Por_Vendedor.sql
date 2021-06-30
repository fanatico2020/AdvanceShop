DROP PROCEDURE IF EXISTS RelatorioVendasPorVendedor;
DELIMITER 
CREATE PROCEDURE RelatorioVendasPorVendedor(in Vendedor varchar(45),in DataInicial DATETIME ,in DataFinal DATETIME)
BEGIN

select v.idvendas as Venda,v.valor as ValorVenda,v.desconto as Desconto,v.totalfinal as TotalVenda,
v.valorpago as ValorPago,v.troco as Troco,v.clientespessoas_idclientespessoas as CodigoCliente,
c.nome as Cliente,d.datahoracadastro as DataVenda,d.usuariocadastro,sum(i.quantidade) as QtdItens from vendas v
left join clientespessoas c on c.idclientespessoas = v.clientespessoas_idclientespessoas
inner join datahora d on v.idvendas = d.vendas_idvendas 
inner join itensvendas i on v.idvendas = i.vendas_idvendas where v.deletado = 0 and
d.usuariocadastro = Vendedor and d.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime) group by v.idvendas;

END;
DELIMITER;


call RelatorioVendasPorVendedor('SORAIA','2021/01/01','2021/08/06');
