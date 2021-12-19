#language: pt

Funcionalidade: Consultar uma roupa
	Eu como usuário, desejo consultar roupas
	para saber escolher uma roupa para comprar

@mytag
Cenário: Consultar camiseta
	Dado eu acesse o site My Store	
	Quando eu desejar procurar uma camiseta
	Então o site me retorna as camisetas disponíveis

