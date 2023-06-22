INSERT INTO public.usuario(
	id, nome, sobrenome, email, telefone, senha)
VALUES (1, 'Gabriella', 'Ostra', 'Gabriella@gmail.com', '659990000', 'a00a00a'),
		(2, 'Jovino', 'santos', 'Jovino@gmail.com', '669990000', 'a00a00a'),
		(3, 'Italo', 'Mattos', 'Italo@gmail.com', '819990000', 'a00a00a'),
		(4, 'Chico', 'chicco', 'Chico@gmail.com', '719990000', 'a00a00a'),
		(5, 'Pérola', 'Ostra', 'Perola@gmail.com', '799990000', 'a00a00a');


INSERT INTO public."tipoImovel"(
	id, descricao)
	VALUES (1, 'casa'),
		(2, 'casa de praia'),
		(3, 'apartamento');

INSERT INTO public.propriedade(
	id, descricao, "idUsuario", "idTipoImovel")
	VALUES (1,  '3 quartos, 1 varanda', 5, 3),
			(2, '2 quartos, 1 sala', 4, 3),
			(3, '1 quartos, varanda', 3, 1),
			(4, '8 quartos, 3 banheiros', 1, 2),
			(5, '6 quartos, 2 copa', 2, 2),
			(6, '3 quartos, com jardim', 1, 1);

INSERT INTO public.imagem(
	id, imagem, "idPropriedade")
	VALUES (1, 'casalindaxx', 1),
			(2, 'casalindaxxx', 2),
			(3, 'casalindaxxxx', 3),
			(4, 'casalindaxxxxx', 4),
			(5, 'casalindaxxxxxx', 5),
			(6, 'casalindaxxxxxxx', 6);

INSERT INTO public.endereco(
	id, rua, numero, cep, bairro, estado, cidade, "idPropriedade")
	VALUES (1, 'Av. BotaFogo', '444', '00000000',  'centro', 'Sergipe' , 'Simão-Dias', 1),
	(2, 'Av. Manuel', '111', '11111111',  'centro',  'Bahia', 'Camaçari', 2),
	(3, 'Av. Gato', '10', '22222222',  'centro', 'Acre', 'Jordão', 3),
	(4, 'Av. Lima', '65', '33333333', 'centro', 'Rio de Janeiro',  'Duque de Caxias', 4),
	(5, 'Av. Guerra', '8', '44444444',  'centro', 'Rio de Janeiro',  'Duque de Caxias', 5),
	(6, 'Av. Palmeiras', '10', '55555555',  'centro', 'Sergipe',  'Simão-Dias',6);


INSERT INTO public."tipoSituacao"(
	id, descricao)
	VALUES (1, 'Aluguel'),
	(2, 'Temporada'),
	(3, 'Venda'),
	(4, 'Venda, Aluguel'),
	(5, 'Venda, Temporada'),
	(6, 'Temporada, Aluguel');

INSERT INTO public.propriedade_tipo_situacao(
	id, valor, idpropriedade, "idTipoSituacao")
	VALUES (1, 4000, 1, 1),
	(2, 230, 3, 2),
	(3, 790, 2, 3),
	(4, 870, 4, 4),
	(5, 1000, 5, 5),
	(6, 700, 6, 6);
