DROP PROCEDURE IF EXISTS RelatorioFechamentoCaixa;
DELIMITER 
CREATE PROCEDURE RelatorioFechamentoCaixa(id_caixa int)

BEGIN

-- saldo inicial
set @saldoinicial =
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa on 
formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and transacoescaixa.descricaotransacao = 'Abertura Caixa' 
and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- entrada dinheiro
set @entradadinheiro =
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and transacoescaixa.descricaotransacao != 'Suplemento, Dinheiro adicionado ao caixa' and 
transacoescaixa.descricaotransacao != 'Abertura Caixa' and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- entrada suplemento
set @entradasuplemento = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and transacoescaixa.descricaotransacao = 'Suplemento, Dinheiro adicionado ao caixa' 
and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- entrada cartão crédito
set @entradacartaocredito = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and formaspagamento.descricao = 'CARTÃO CRÉDITO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- entrada cartão débito
set @entradacartaodebito = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and formaspagamento.descricao = 'CARTÃO DÉBITO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- entrada transferencia bancária
set @entradatransferenciabancaria = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and formaspagamento.descricao = 'TRANSFERÊNCIA BANCÁRIA' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);


-- entrada link pagamento
set @entradalinkpagamento = 
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 1 and formaspagamento.descricao = 'LINK PAGAMENTO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- saida sangria
set @saidasangria =
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 0 and transacoescaixa.descricaotransacao = 'Sangria, Dinheiro retirado do caixa' 
and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- saida troco
set @saidatroco = 
(select ifnull(sum(vendas.troco), 0) from vendas where deletado = 0 and caixas_idcaixas = id_caixa);

-- saida troca / devolução
set @saidadevolucoes =
(select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa 
on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa 
where transacoescaixa.tipo = 0 and transacoescaixa.descricaotransacao = 'Devolução, troca/devolução de mercadoria' 
and transacoescaixa.deletado = 0 and transacoescaixa.caixas_idcaixas = id_caixa);

-- saldo final
set @saldofinal = 
(select ifnull(sum(saldofinal),0) from caixas where idcaixas = id_caixa);

-- valor informado
set @valorinformado = 
(select ifnull(sum(valorinformado),0) from caixas where idcaixas = id_caixa);

-- quebra de caixa
set @quebracaixa = 
(select ifnull(sum(quebracaixa),0) from caixas where idcaixas = id_caixa);

-- Data Termino do caixa
set @datahoraterminocaixa = 
(select date_format(datahorafechamento,"%d/%m/%Y %H:%i") from caixas where idcaixas = id_caixa);

-- Data Inicio do caixa
set @datahorainiciocaixa =
(select date_format(datahoracadastro,"%d/%m/%Y %H:%i") from datahora where caixas_idcaixas = id_caixa);

-- Usuario do caixa
set @usuariocaixa = 
(select usuarioacesso from caixas inner join usuarios on usuarios.idusuarios = caixas.usuarios_idusuarios where idcaixas = id_caixa);

-- Usuario fechamento
set @usuariofechamento =
(select usuariofechamento from caixas where idcaixas = id_caixa);

-- Observação caixa
set @observacaocaixa = 
(select observacaocaixa from caixas where idcaixas = id_caixa);

select @saldoinicial,@entradadinheiro,@entradasuplemento,@entradacartaocredito,@entradacartaodebito,@entradatransferenciabancaria,@entradalinkpagamento,@saidatroco,@saidasangria,@saidadevolucoes,@saldofinal,@valorinformado,@quebracaixa,@datahoraterminocaixa,@datahorainiciocaixa,@usuariocaixa,@usuariofechamento,@observacaocaixa;

END;
DELIMITER;

call RelatorioFechamentoCaixa(1);

