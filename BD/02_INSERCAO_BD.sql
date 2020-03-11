USE SENATUR_TARDE

INSERT INTO Pacotes (NomePacotes,Descricao,DataIda,Datavolta,Valor,Ativo,NomeCidade)
VALUES('Salvador - 5 dias  4 Di�rias','O que n�o falta em Salvador s�o atra��es. Prova disso s�o as praias, os museus e as constru��es seculares que d�o um charme mais que especial � regi�o. A cidade, sin�nimo de alegria, tamb�m � conhecida pela efervesc�ncia cultural que acredenciou como um dos destinos mais procurados por turistas brasileiros e estrangeiros. O Pelourinho e o Elevador s�o alguns dos principais pontos de visita��o.','06/08/2020','10/08/2020',854.00,1,'Salvador'),
	   ('Resorts na Bahia - Litoral Norte - 5 dias 4 di�rias','O Litoral Norte da Bahia conta com in�meras praias emolduradas por coqueiros, al�m de piscinas naturais de �guas mornas que s�o protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em �guas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e cal�ad�es,passeios de bicicleta, pontos tur�sticos hist�ricos, intera��o com animais e at� baladas est�o entre as atra��es da regi�o. Destacam-se as praias de Guarajuba, Imbassa�,Praia do Forte e Costa do Sauipe.','14/05/2020','18/05/2020',1826.00,1,'Salvador'),
	   ('Bonito via Campo Gande - 1 Passeio - 5 dias/4 di�rias',' Localizado no estado de Mato Grosso do Sul e ao sul do Pantanal, Bonito possui centenas de cachoeiras, rios e lagos de �guas cristalinas, al�m de cavernas inundadas, pared�es rochosos e uma infinidade de peixes.Os aventureiros costumam render-se facilmente a esse destino regado por trilhas ecol�gicas, passeios de bote e descidas de rapel pelas in�meras quedas de �gua da regi�o','28/03/2020','01/04/2020',1004.00,1,'Cidade Bonito');

INSERT INTO TiposUsuarios(Titulo)
VALUES ('Adinistrador'),('Usuario')

INSERT INTO Usuarios(Email,Senha,IdTiposUsuarios)
VALUES ('admin@admin.com','admin',1),
       ('cliente@cliente.com','cliente',2)