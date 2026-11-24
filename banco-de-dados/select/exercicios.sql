select * from clientes
select * from produtos where categoria = "Periféricos"
SELECT nome, preco FROM produtos where preco > 100
SELECT * FROM produtos WHERE categoria = "Periféricos" and preco < 100
SELECT * FROM clientes WHERE cidade = "Sumaré" or cidade = "Campinas"
SELECT * FROM clientes WHERE cidade in ("Sumaré", "Campinas")
SELECT * FROM produtos WHERE preco between 50 and 200
SELECT * FROM produtos WHERE not categoria = "Monitores"
SELECT * FROM pedidos WHERE data_pedido > "2026-09-01"
SELECT * FROM produtos where categoria = "Periféricos" and estoque >= 10 and preco between 50 and 200
