DROP PROCEDURE IF EXISTS RelatorioProdutosMaisVendidos;
DELIMITER 
CREATE PROCEDURE RelatorioProdutosMaisVendidos(in DataInicial DATETIME ,in DataFinal DATETIME)
BEGIN

select produtos.idprodutos,produtos.descricaoproduto,produtos.codigobarra, 
ifnull(count(itensvendas.quantidade),0) as quantidade,ifnull(sum(itensvendas.precocusto),0) as totalcusto, 
ifnull(sum(itensvendas.valorunitario),0) as totalvenda from itensvendas inner join 
produtos on produtos.idprodutos = itensvendas.produtos_idprodutos inner join
vendas on vendas.idvendas = itensvendas.vendas_idvendas  left join  
datahora on datahora.vendas_idvendas = itensvendas.vendas_idvendas 
where vendas.deletado = 0 and datahora.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime) 
group by produtos.idprodutos order by sum(itensvendas.quantidade) desc ;
END;
DELIMITER;


call RelatorioProdutosMaisVendidos('2021/05/01','2021/06/17');
