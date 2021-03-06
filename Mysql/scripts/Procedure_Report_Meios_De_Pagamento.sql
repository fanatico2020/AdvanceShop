DROP PROCEDURE IF EXISTS RelatorioMeiosDePagamento;
DELIMITER 
CREATE PROCEDURE RelatorioMeiosDePagamento(in DataInicial DATETIME,in DataFinal DATETIME)
BEGIN


set @totaldinheiro =
(select ifnull(sum(formaspagamento.valor),0)from formaspagamento left join transacoescaixa on 
formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa inner join 
datahora on datahora.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where 
formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0 and transacoescaixa.tipo = 1 
and datahora.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime));

set @totalcartaocredito = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa on 
formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa inner join 
datahora on datahora.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where 
formaspagamento.descricao = 'CARTÃO CRÉDITO' and transacoescaixa.deletado = 0 and transacoescaixa.tipo = 1 
and datahora.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime));

set @totalcartaodebito =
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa on 
formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa inner join 
datahora on datahora.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where 
formaspagamento.descricao = 'CARTÃO DÉBITO' and transacoescaixa.deletado = 0 and transacoescaixa.tipo = 1 
and datahora.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime));

set @totaltransferenciabancaria =
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa on 
formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa inner join 
datahora on datahora.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where 
formaspagamento.descricao = 'TRANSFERÊNCIA BANCÁRIA' and transacoescaixa.deletado = 0 and transacoescaixa.tipo = 1 
and datahora.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime));

set @totallinkpagamento = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa on 
formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa inner join 
datahora on datahora.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where 
formaspagamento.descricao = 'LINK PAGAMENTO' and transacoescaixa.deletado = 0 and transacoescaixa.tipo = 1 
and datahora.datahoracadastro between 
cast(DataInicial as datetime) and cast(DataFinal as datetime));

select @totaldinheiro,@totalcartaocredito,@totalcartaodebito,@totaltransferenciabancaria,@totallinkpagamento;
END;
DELIMITER;


call RelatorioMeiosDePagamento('2021/05/13 00:00:00','2021/05/13 23:59:59');
