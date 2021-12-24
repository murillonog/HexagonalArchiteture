Hexagonal Architeture
=================

# Introdução
Projeto de estudo sobre arquitetura hexagonal em .NET CORE 6.0. Existe uma característica particular nesta arquitetura em si. 
Ela, também, é conhecida como “Ports and Adapters”, onde o termo “Ports” (ou portas) representa as interfaces sua aplicação, 
utilizadas tanto para entrada e/ou saída. E os “Adapters”, seria as implementações de tais interfaces. Como exemplo de saídas, 
podemos destacar a comunicação com algum banco de dados, fila, logs e, como exemplo de entradas, podemos destacar o consumo da 
nossa aplicação através da exposição de APIs. Entendido esse conceito, temos o Core da aplicação como ponto focal, onde o acesso 
a ele se dá pelos “Ports and Adapters”, tais códigos são do domínio do negócio, onde neles não há interferência externa.

1.Adaptadores Primários
Também conhecidos como “Driving Adapters” (ou Adaptadores de Direção), representam os adaptadores de entrada, ou seja, 
na maioria dos casos pode representar a interface com o usuário. Isso se dá, pois eles conduzem a aplicação e iniciam ações 
nela. Neste caso teremos, como exemplo, controladores de APIs, controladores Web ou, simplesmente, Views.

2.Adaptadores Secundários
Também chamados de “Driven Adapters” (ou adaptadores acionados), representam os adaptadores de saída, ou seja, a conexão com 
o mundo externo. Eles reagem de acordo com as ações feitas nos adaptadores primários. Neste caso temos, como exemplo, conexões 
com banco de dados, APIs, bibliotecas, envios de Email e registros de Logs.

![alt text](https://miro.medium.com/max/1050/1*NySTso0XK5eml46vGODu8Q.png)