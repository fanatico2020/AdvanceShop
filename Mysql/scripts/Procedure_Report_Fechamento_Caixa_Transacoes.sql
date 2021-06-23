DROP PROCEDURE IF EXISTS RelatorioFechamentoCaixaTransacoes;
DELIMITER 
CREATE PROCEDURE RelatorioFechamentoCaixaTransacoes(id_caixa int)

BEGIN

select idtransacoescaixa,if(tipo = 1,'1 - Entrada','0 - Saída') as Tipo,descricaotransacao,valor,observacaotransacao from transacoescaixa where caixas_idcaixas = id_caixa;

END;
DELIMITER;

call RelatorioFechamentoCaixaTransacoes(3);

